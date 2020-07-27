using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Company
{
    public partial class ChangeComMyInfo : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        //메인폼에 메시지 전달
        public delegate void sendMsgDelegate(string msg);
        public event sendMsgDelegate sendMsg;

        public ChangeComMyInfo()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeMyInfo_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            text_phone.Text = MainForm.getPhone();
            text_name.Text = MainForm.getName();
            text_addr.Text = MainForm.getAddr();
            text_email.Text = MainForm.getEmail();
            text_comName.Text = MainForm.getCom_name();
            text_comTel.Text = MainForm.getCom_tel();
            text_comAddr.Text = MainForm.getCom_addr();
            text_comNum.Text = MainForm.getCom_num();
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

        // 이름, 주소, 회사이름, 회사주소, 사업자번호, 회원 핸드폰번호, 회사 전화번호, 회원 이메일 정보를 업데이트 한다.
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (check_com_textbox())
            {
                SqlConnection sqlcon = new SqlConnection(DBConnection.strconn);
                try
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("update COM_CUSTOMER set NAME=@name, ADDR=@addr, COM_NAME=@com_name" +
                        ", COM_ADDR=@com_addr, COM_NUM=@com_num, PHONE = @phone" +
                        ", COM_TEL=@com_tel, EMAIL=@email where ID = @id", sqlcon);
                    cmd.Parameters.AddWithValue("@name", text_name.Text);
                    cmd.Parameters.AddWithValue("@addr", text_addr.Text);
                    cmd.Parameters.AddWithValue("@com_name", text_comName.Text);
                    cmd.Parameters.AddWithValue("@com_addr", text_comAddr.Text);
                    cmd.Parameters.AddWithValue("@com_num", text_comNum.Text);
                    cmd.Parameters.AddWithValue("@phone", text_phone.Text);
                    cmd.Parameters.AddWithValue("@com_tel", text_comTel.Text);
                    cmd.Parameters.AddWithValue("@email", text_email.Text);
                    cmd.Parameters.AddWithValue("@id", MainForm.getID());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("수정이 완료되었습니다!");
                    Log.printLog("정보 수정 성공");
                    sendMsg("OK");
                }
                catch (Exception ee)
                {
                    Log.printLog("정보 수정 실패");
                    Console.WriteLine(ee.StackTrace);
                }
                finally
                {
                    if (sqlcon != null)
                        sqlcon.Close();
                    this.Close();
                }
            }
            
            
                      
        }
        // 기업 회원 텍스트박스 확인
        private bool check_com_textbox()
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
            else if (String.IsNullOrEmpty(text_comName.Text) || String.IsNullOrWhiteSpace(text_comName.Text) || "Company Name".Equals(text_comName.Text))
                MessageBox.Show("기업명을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comAddr.Text) || String.IsNullOrWhiteSpace(text_comAddr.Text) || "Company address".Equals(text_comAddr.Text))
                MessageBox.Show("기업 주소를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comNum.Text) || String.IsNullOrWhiteSpace(text_comNum.Text) || "000000000".Equals(text_comNum.Text) || (text_comNum.TextLength < 10))
                MessageBox.Show("사업자번호를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comTel.Text) || String.IsNullOrWhiteSpace(text_comTel.Text) || text_comTel.Text.Contains('-'))
                MessageBox.Show("기업 전화번호를 정확히 입력해주세요.");
            else
                check = true;

            return check;
        }
    }
}
