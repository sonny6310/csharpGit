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

namespace Login.Individual
{
    public partial class ChangeInMyInfo : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        //메인폼에 메시지 전달
        public delegate void sendMsgDelegate(string msg);
        public event sendMsgDelegate sendMsg;

        public ChangeInMyInfo()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeInMyInfo_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            text_phone.Text = IMemberMainForm.getPhone();
            text_name.Text = IMemberMainForm.getName();
            text_addr.Text = IMemberMainForm.getAddr();
            text_email.Text = IMemberMainForm.getEmail();
        }

        // 이름, 주소, 이메일, 핸드폰번호 수정
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (check_customer_textbox())
            {
                SqlConnection sqlcon = new SqlConnection(DBConnection.strconn);
                try
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("update CUSTOMER set NAME=@name, ADDR=@addr, EMAIL=@email, PHONE=@phone where ID=@id", sqlcon);
                    cmd.Parameters.AddWithValue("@name", text_name.Text);
                    cmd.Parameters.AddWithValue("@addr", text_addr.Text);
                    cmd.Parameters.AddWithValue("@email", text_email.Text);
                    cmd.Parameters.AddWithValue("@phone", text_phone.Text);
                    cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("수정이 완료되었습니다!");
                    sendMsg("OK");
                    Log.printLog("개인회원 정보 수정 완료");
                }
                catch (Exception)
                {
                    Log.printLog("개인회원 정보 수정 에러");
                    MessageBox.Show("에러");
                }
                finally
                {
                    sqlcon.Close();
                    this.Close();
                }
            }
            
        }
        // 개인 회원 텍스트박스 확인
        private bool check_customer_textbox()
        {
            bool check = false;
            if (String.IsNullOrEmpty(text_name.Text) || String.IsNullOrWhiteSpace(text_name.Text) || "User Name".Equals(text_name.Text))
                MessageBox.Show("이름을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_addr.Text) || String.IsNullOrWhiteSpace(text_addr.Text) || "User address".Equals(text_addr.Text))
                MessageBox.Show("주소를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_email.Text) || String.IsNullOrWhiteSpace(text_email.Text) || "someone@email.com".Equals(text_email.Text))
                MessageBox.Show("이메일을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_phone.Text) || String.IsNullOrWhiteSpace(text_phone.Text) || text_phone.Text.Contains('-'))
                MessageBox.Show("전화번호를 정확히 입력해주세요.");
            else
                check = true;

            return check;
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

    }
}
