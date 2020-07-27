using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class Form1 : Form
    {
        Dictionary<string, CtUser> diction = new Dictionary<string, CtUser>();

        public Form1()
        {
            InitializeComponent();
        }

        public static insert ManagerInsert = new insert();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();
        }

        //마우스 클릭 이동 (상단바)
        private Point mousePoint;
        private void topP_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void topP_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            insert insert = new insert();
            insert.Show();
            //Form1.ManagerInsert.Show();
        }

        private void updata_Click(object sender, EventArgs e)
        {
            update update = new update();
            update.Show();
        }

        //주문테이블의 변화 하는지 안하는지 비교해서 리플래쉬 여부를 결정(5초마다 체크)
        int new_count = 0;//카운트 비교용 변수

        private void timer1_Tick(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect();
            DataSet dsCount = db.orderCount();
            DataTable dtCount = dsCount.Tables[0];
            int count = int.Parse(dtCount.Rows[0][0].ToString());
            Console.WriteLine(count);
            Console.WriteLine(new_count);

            if (count != new_count)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\Resources\order.wav");
                simpleSound.Play();
                
                MessageBox.Show("들어온 주문이 있습니다");
                new_count = count;
                initOrder();
            }
        }
        //오더 아이템 생성
        private void initOrder()
        {
            dbConnect db = new dbConnect();
            DataSet ds = db.OrderTable();
            DataSet dsCount = db.orderCount();
            DataTable dtCount = dsCount.Tables[0];
            int count = int.Parse(dtCount.Rows[0][0].ToString());

            flowLayoutPanel1.Controls.Clear();
            List<string[]> list = new List<string[]>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //생성된 오더아이템 갯수
                    int flow_count = flowLayoutPanel1.Controls.Count + 1;

                    if (i == 0) //전체 통합 주문의 맨 첫번째
                    {
                        if (flow_count == count) // 첫번째 주문에 1개 밖에 주문이 없으면 수행
                        {
                            string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                            list.Add(menu);
                            CtUser c1 = new CtUser(ds.Tables[0].Rows[i], list);
                            flowLayoutPanel1.Controls.Add(c1);
                            c1.Show();
                            list.Clear();
                        }
                        else // 아니면 리스트에 추가
                        {
                            string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                            list.Add(menu);
                        }
                    }
                    else //통합 첫번째 주문을 제외한 모든 경우
                    {
                        //직전 주문과 PC_Num, 주문 시간이 같은 경우
                        if (ds.Tables[0].Rows[i]["PC_Num"].Equals(ds.Tables[0].Rows[i - 1]["PC_Num"]) && ds.Tables[0].Rows[i]["Order_Time"].Equals(ds.Tables[0].Rows[i - 1]["Order_Time"]))
                        {
                            //통합 맨 마지막 주문의 맨 마지막 메뉴의 경우
                            if (i == ds.Tables[0].Rows.Count - 1)
                            {
                                string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                                list.Add(menu);
                                CtUser c2 = new CtUser(ds.Tables[0].Rows[i], list);
                                flowLayoutPanel1.Controls.Add(c2);
                                c2.Show();
                            }
                            else // 통합 맨 마지막 주문의 맨 마지막 메뉴의 경우가 아닌 경우
                            {
                                string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                                list.Add(menu);
                            }

                        }
                        else // 직전 주문과 PC_Num, 주문 시간이 다른 경우
                        {
                            //맨 마지막 주문의 맨 마지막 메뉴일 경우
                            if (i == ds.Tables[0].Rows.Count - 1)
                            {
                                //직전 주문을 바로 생성해준다
                                CtUser c1 = new CtUser(ds.Tables[0].Rows[i - 1], list);
                                flowLayoutPanel1.Controls.Add(c1);
                                c1.Show();
                                list.Clear();
                                //리스트를 초기화하고 다시 메뉴를 만들어서 생성한다
                                string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                                list.Add(menu);
                                CtUser c2 = new CtUser(ds.Tables[0].Rows[i], list);
                                flowLayoutPanel1.Controls.Add(c2);
                                c2.Show();
                            }
                            else
                            {
                                //직전의 주문을 폼 생성해주고 리스트를 초기화 후 메뉴리스트에는 현재 주문에 대한 메뉴를 추가해준다.
                                CtUser c1 = new CtUser(ds.Tables[0].Rows[i - 1], list);
                                flowLayoutPanel1.Controls.Add(c1);
                                c1.Show();
                                list.Clear();
                                string[] menu = { ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["count"].ToString() };
                                list.Add(menu);
                            }
                        }
                    }

                }


            }
        }

        //현재시간
        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yy.MM.dd hh:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
