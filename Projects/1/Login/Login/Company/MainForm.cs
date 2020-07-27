using Login.Company;
using LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MainForm : Form
    {
        //로그인에서 기업회원을 선택해서 로그인 할 경우 true로 바뀐다.
        private static bool formOpen = false;
        //마우스로 창 이동
        bool On;
        Point Pos;

        //메뉴 버튼을 누를 때 마다 현재 버튼이 어떤 버튼인지 알게 하고 색을 바꿈
        private Button currentButton = null;
        static Com_customer user = Form1.getCom_userInstance();

        //DB연결
        static string strconn = DBConnection.strconn;

        public MainForm()
        {
            InitializeComponent();

            //현재 날짜 및 시간
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            
            //메뉴2는 static 변수로 선언, 다른 폼에서 참조 가능
            Menu2.setInstance(menu21);
        }
        
        private void readUserInfo(string id) //로그인 된 사용자의 정보를 읽어서 Com_customer클래스에 넣어줌
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from COM_CUSTOMER where id = @id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader sdr = cmd.ExecuteReader();
            
                while (sdr.Read())
                {
                    user.ID = sdr["ID"].ToString();
                    user.PW = sdr["PW"].ToString();
                    lb_username.Text = sdr["NAME"].ToString();
                    user.NAME = lb_username.Text;
                    user.ADDR = sdr["ADDR"].ToString();
                    user.COM_NAME = sdr["COM_NAME"].ToString();
                    user.COM_ADDR = sdr["COM_ADDR"].ToString();
                    user.COM_NUM = sdr["COM_NUM"].ToString();
                    user.PHONE = sdr["PHONE"].ToString();
                    user.COM_TEL = sdr["COM_TEL"].ToString();
                    user.EMAIL = sdr["EMAIL"].ToString();
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
        }

        // Com_customer 클래스 변수로 선언된 userid에 id나 비밀번호 등 해당되는 값을 set, get 하는 함수들
       
        public static string getID()
        {
            return user.ID;
        }
        public static string getPW()
        {
            return user.PW;
        }
        public static string getName()
        {
            return user.NAME;
        }
        public static string getAddr()
        {
            return user.ADDR;
        }
        public static string getCom_name()
        {
            return user.COM_NAME;
        }
        public static string getCom_addr()
        {
            return user.COM_ADDR;
        }
        public static string getCom_num()
        {
            return user.COM_NUM;
        }
        public static string getPhone()
        {
            return user.PHONE;
        }
        public static string getCom_tel()
        {
            return user.COM_TEL;
        }
        public static string getEmail()
        {
            return user.EMAIL;
        }

        private void ActivateButton(object btnSender) //현재 버튼과 직전의 버튼 색을 바꾸는 함수
        {
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    if(btnSender != currentButton)
                    {
                        currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
                        currentButton.ForeColor = System.Drawing.Color.White;
                    }


                }
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;

                    currentButton.BackColor = System.Drawing.Color.White;
                    currentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));

                }
            }
        }
        private void btn_menu1_Click(object sender, EventArgs e) // 구인등록
        {
            menu11.BringToFront();
            ActivateButton(btn_menu1);
        }

        private void btn_menu2_Click(object sender, EventArgs e) // 구인목록
        {
            
            menu21.BringToFront();
            ActivateButton(btn_menu2);
        }
        
        private void btn_menu3_Click(object sender, EventArgs e) // 이력서 조회
        {
            menu31.BringToFront();
            ActivateButton(btn_menu3);
        }

        private void btn_menu4_Click(object sender, EventArgs e) // 채용 관리
        {
            menu41.BringToFront();
            ActivateButton(btn_menu4);
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            On = true;
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            if (On == true)
            {
                this.SetDesktopLocation(MousePosition.X - Pos.X, MousePosition.Y - Pos.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            On = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Log.printLog("기업회원 프로그램 종료");
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) //현재 시간 보여주는 함수
        {
            DateTime time = DateTime.Now;
            string timeView = time.ToString("yyyy") + "년 " + time.ToString("MM") + "월 " + time.ToString("dd") + "일 " + "(" + time.ToString("ddd") + ") " + time.ToString("hh") + "시" + time.ToString("mm") + "분" + time.ToString("ss") + "초";
            lb_date.Text = timeView;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (formOpen == false)
            {
                this.Close();
            }
            if (user.ID == "admin")
            {
                btn_admin_menu.Visible = true;
            }
            //메인폼에 유저 이름 표시
            lb_username.Text = user.NAME;

        }
        public static void setFormOpen(bool open) // 기업회원 폼이 열리는지 체크하는 함수, 안열리면 바로 닫게 설계되어있음
        {
            formOpen = open;
        }
        public static bool getFormOpen()
        {
            return formOpen;
        }
        private void pictureBox2_Click(object sender, EventArgs e) // 맨 처음 로고화면으로 돌아감
        {
            afterLoginMainPage1.BringToFront();
        }

        private void btn_admin_menu_Click(object sender, EventArgs e) // 관리자 메뉴(기업정보추가)
        {
            ComManage form = new ComManage();
            form.Show();
        }
        
        private void 사용자정보수정ToolStripMenuItem_Click(object sender, EventArgs e) // 사용자 이름 오른쪽 버튼 클릭하면 있는 메뉴
        {
            ChangeComMyInfo cmi = new ChangeComMyInfo();
            cmi.sendMsg += new ChangeComMyInfo.sendMsgDelegate(refreshInfo);
            cmi.Show();
        }
        private void refreshInfo(string msg) // 사용자 정보가 수정되면 폼에 정보를 다시 받아온다.
        {
            if(msg == "OK")
            {
                readUserInfo(user.ID);
            }
        }

        private void 비밀번호변경ToolStripMenuItem_Click(object sender, EventArgs e) // 사용자 이름 오른쪽 버튼 클릭하면 있는 메뉴
        {
            ChangeMyPW cmpw = new ChangeMyPW("COM_CUSTOMER");
            cmpw.Show();
        }
    }
}
