using Login.Individual;
using LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class IMemberMainForm : Form
    {
        private static bool formOpen = false;

        //마우스로 창 이동
        bool On;
        Point Pos;

        private Button currentButton = null;
        //DB연결
        string strconn = DBConnection.strconn;
        private static Customer user = Form1.getUserInstance();
        public IMemberMainForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }
        private void readUserInfo(string id) //로그인 된 사용자의 정보를 읽어서 Com_customer클래스에 넣어줌
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                string table_name = "CUSTOMER";
                SqlCommand cmd = new SqlCommand($"select * from {table_name} where ID = @id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    user.ID = sdr["ID"].ToString();
                    user.PW = sdr["PW"].ToString();
                    lb_username.Text = sdr["NAME"].ToString();
                    user.NAME = lb_username.Text;
                    user.ADDR = sdr["ADDR"].ToString();
                    user.PHONE = sdr["PHONE"].ToString();
                    user.EMAIL = sdr["EMAIL"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
            
            
        }
        public static string getID() { return user.ID; }
        public static string getPW(){ return user.PW; }
        public static string getName() { return user.NAME; }
        public static string getAddr() { return user.ADDR; }
        public static string getPhone() { return user.PHONE; }
        public static string getEmail() { return user.EMAIL; }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    if(currentButton != btnSender)
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
        private void btn_menu1_Click(object sender, EventArgs e)
        {
            iMenu11.BringToFront();
            ActivateButton(btn_menu1);
        }

        private void btn_menu2_Click(object sender, EventArgs e)
        {
            iMenu21.BringToFront();
            ActivateButton(btn_menu2);
        }

        private void btn_menu3_Click(object sender, EventArgs e)
        {
            iMenu31.BringToFront();
            ActivateButton(btn_menu3);
        }

        private void btn_menu4_Click(object sender, EventArgs e)
        {
            iMenu41.BringToFront();
            ActivateButton(btn_menu4);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            On = true;
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (On == true)
            {
                this.SetDesktopLocation(MousePosition.X - Pos.X, MousePosition.Y - Pos.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            On = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Log.printLog("개인회원 프로그램 종료");
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string timeView = time.ToString("yyyy") + "년 " + time.ToString("MM") + "월 " + time.ToString("dd") + "일 " + "(" + time.ToString("ddd") + ") " + time.ToString("hh") + "시" + time.ToString("mm") + "분" + time.ToString("ss") + "초";
            lb_date.Text = timeView;
        }

        private void IMemberMainForm_Load(object sender, EventArgs e)
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
        
        public static void setFormOpen(bool open) // 폼이 열려있는지 체크, 안열리면 바로 닫게 설계 되어있다.
        {
            formOpen = open;
        }
        public static bool getFormOpen()
        {
            return formOpen;
        }
        private void pictureBox2_Click(object sender, EventArgs e) // 로고가 있는 처음 화면을 띄움
        {
            afterLoginMainPage1.BringToFront();
        }

        private void 사용자정보수정ToolStripMenuItem_Click(object sender, EventArgs e) // 사용자 이름 오른쪽 버튼 클릭 메뉴
        {
            ChangeInMyInfo cimi = new ChangeInMyInfo();
            
            cimi.sendMsg += new ChangeInMyInfo.sendMsgDelegate(refreshInfo);
            cimi.Show();
        }
        private void refreshInfo(string msg) // 사용자정보가 수정되면 폼에 정보를 다시 받아온다
        {
            if (msg == "OK")
            {
                readUserInfo(user.ID);
            }
        }
        private void 비밀번호변경ToolStripMenuItem_Click(object sender, EventArgs e) // 사용자 이름 오른쪽 버튼 클릭 메뉴
        {
            ChangeMyPW cmpw = new ChangeMyPW("CUSTOMER");
            cmpw.Show();
        }

        private void btn_admin_menu_Click(object sender, EventArgs e) //관리자 메뉴(기업정보추가)
        {
            ComManage form = new ComManage();
            form.Show();
        }
    }
}
