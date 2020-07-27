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
    public partial class SignUp : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;
        string strconn = DBConnection.strconn;
        private string table_name = "CUSTOMER";
        private bool ID_check = false;
        SqlConnection conn = new SqlConnection(DBConnection.strconn);
        SqlCommand cmd;

        public SignUp()
        {
            InitializeComponent();
            rbtn_customer.Checked = true;
            text_comNum.MaxLength = 10;
        }
        // 고객 회원 라디오 버튼 클릭 - textbox 비활성화
        private void rbtn_customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_customer.Checked == true)
            {
                text_comAddr.Enabled = false;
                text_comNum.Enabled = false;
                text_comName.Enabled = false;
                text_comTel.Enabled = false;
            }
            else
            {
                text_comAddr.Enabled = true;
                text_comNum.Enabled = true;
                text_comName.Enabled = true;
                text_comTel.Enabled = true;
            }
        }
        // 개인 회원 insert
        private void insert_customer()
        {

            table_name = "CUSTOMER";
            cmd = new SqlCommand($"insert into {table_name} (ID, PW, NAME, ADDR, EMAIL, PHONE) values (@ID, @PW, @NAME, @ADDR, @EMAIL, @PHONE)", conn);
            cmd.Parameters.AddWithValue("@ID", text_id.Text);
            cmd.Parameters.AddWithValue("@PW", text_pw.Text);
            cmd.Parameters.AddWithValue("@NAME", text_name.Text);
            cmd.Parameters.AddWithValue("@ADDR", text_addr.Text);
            cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
            cmd.Parameters.AddWithValue("@PHONE", text_phone.Text);
            MessageBox.Show("개인 회원가입 되었습니다.");
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }
        // 기업 회원 insert
        private void insert_com()
        {
            table_name = "COM_CUSTOMER";
            cmd = new SqlCommand($"insert into {table_name} (ID, PW, NAME, ADDR, COM_NAME, COM_ADDR, COM_NUM, PHONE, COM_TEL, EMAIL) values (@ID, @PW, @NAME, @ADDR, @COM_NAME, @COM_ADDR, @COM_NUM, @PHONE, @COM_TEL, @EMAIL)", conn);
            cmd.Parameters.AddWithValue("@ID", text_id.Text);
            cmd.Parameters.AddWithValue("@PW", text_pw.Text);
            cmd.Parameters.AddWithValue("@NAME", text_name.Text);
            cmd.Parameters.AddWithValue("@ADDR", text_addr.Text);
            cmd.Parameters.AddWithValue("@COM_NAME", text_comName.Text);
            cmd.Parameters.AddWithValue("@COM_ADDR", text_addr.Text);
            cmd.Parameters.AddWithValue("@COM_NUM", text_comNum.Text);
            cmd.Parameters.AddWithValue("@PHONE", text_phone.Text);
            cmd.Parameters.AddWithValue("@COM_TEL", text_comTel.Text);
            cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
            MessageBox.Show("기업 회원가입 되었습니다.");
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }
        // 개인 회원 텍스트박스 공백 확인
        private void check_customer_textbox()
        {
            if (String.IsNullOrEmpty(text_name.Text) || String.IsNullOrWhiteSpace(text_name.Text) || "User Name".Equals(text_name.Text))
                MessageBox.Show("이름을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_pw.Text) || String.IsNullOrWhiteSpace(text_pw.Text) || "User PW".Equals(text_pw.Text))
                MessageBox.Show("비밀번호를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_addr.Text) || String.IsNullOrWhiteSpace(text_addr.Text) || "User address".Equals(text_addr.Text))
                MessageBox.Show("주소를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_email.Text) || String.IsNullOrWhiteSpace(text_email.Text) || "someone@email.com".Equals(text_email.Text))
                MessageBox.Show("이메일을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_phone.Text) || String.IsNullOrWhiteSpace(text_phone.Text) || "'-' 빼고 입력해주세요".Equals(text_phone.Text))
                MessageBox.Show("전화번호를 정확히 입력해주세요.");
            else
                insert_customer();
        }
        // 기업 회원 텍스트박스 확인
        private void check_com_textbox()
        {
            if (String.IsNullOrEmpty(text_name.Text) || String.IsNullOrWhiteSpace(text_name.Text) || "User Name".Equals(text_name.Text))
                MessageBox.Show("이름을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_pw.Text) || String.IsNullOrWhiteSpace(text_pw.Text) || "User PW".Equals(text_pw.Text))
                MessageBox.Show("비밀번호를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_addr.Text) || String.IsNullOrWhiteSpace(text_addr.Text) || "User address".Equals(text_addr.Text))
                MessageBox.Show("주소를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_email.Text) || String.IsNullOrWhiteSpace(text_email.Text) || "someone@email.com".Equals(text_email.Text))
                MessageBox.Show("이메일을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_phone.Text) || String.IsNullOrWhiteSpace(text_phone.Text) || "'-' 빼고 입력해주세요".Equals(text_phone.Text))
                MessageBox.Show("전화번호를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comName.Text) || String.IsNullOrWhiteSpace(text_comName.Text) || "Company Name".Equals(text_comName.Text))
                MessageBox.Show("기업명을 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comAddr.Text) || String.IsNullOrWhiteSpace(text_comAddr.Text) || "Company address".Equals(text_comAddr.Text))
                MessageBox.Show("기업 주소를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comNum.Text) || String.IsNullOrWhiteSpace(text_comNum.Text) || "000000000".Equals(text_comNum.Text) || (text_comNum.TextLength < 10))
                MessageBox.Show("사업자번호를 정확히 입력해주세요.");
            else if (String.IsNullOrEmpty(text_comTel.Text) || String.IsNullOrWhiteSpace(text_comTel.Text) || "'-' 빼고 입력해주세요".Equals(text_comTel.Text))
                MessageBox.Show("기업 전화번호를 정확히 입력해주세요.");
            else
                insert_com();
        }
        // 텍스트 박스 글자 색 변경
        private void textbox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            ((TextBox)sender).ForeColor = System.Drawing.Color.Black;
        }

        private void text_id_Enter(object sender, EventArgs e)
        {
            text_id.Text = "";
            text_id.ForeColor = System.Drawing.Color.Black;
            ID_check = false;
        }
        #region id중복확인 버튼
        private void btn_idCheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                if(String.IsNullOrEmpty(text_email.Text) || String.IsNullOrWhiteSpace(text_email.Text))
                {
                    MessageBox.Show("ID를 입력하세요.");
                }
                // 개인 회원 테이블 확인
                else if (rbtn_customer.Checked == true)
                {
                    table_name = "CUSTOMER";
                    cmd = new SqlCommand($"select ID from {table_name} where ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", text_id.Text);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    // 중복된 id가 있을 경우
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("아이디가 중복됩니다.\n다른 아이디를 입력하세요.");
                        ds.Reset();
                    }
                    // 중복된 id가 없을 경우
                    else
                    {
                        MessageBox.Show("아이디 사용 가능");
                        ID_check = true;
                    }
                }
                // 기업 회원 테이블 확인
                else
                {
                    table_name = "COM_CUSTOMER";
                    cmd = new SqlCommand($"select ID from {table_name} where ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", text_id.Text);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    // 중복된 id가 있을 경우
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("아이디가 중복됩니다.\n다른 아이디를 입력하세요.");
                        ds.Reset();
                    }
                    // 중복된 id가 없을 경우
                    else
                    {
                        MessageBox.Show("아이디 사용 가능");
                        ID_check = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        #endregion
        // 회원가입 버튼 클릭
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (ID_check)
            {
                try
                {
                    conn.Open();
                    // 고객 회원 라디오 버튼 클릭
                    if (rbtn_customer.Checked == true)
                    {
                        check_customer_textbox();
                    }
                    // 기업 회원 라디오 버튼 클릭
                    else
                    {
                        check_com_textbox();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("에러");
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }
            else
            {
                MessageBox.Show("ID 중복 확인을 해주세요.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
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
        
        // 이름 문자만 입력
        private void text_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsPunctuation(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // 숫자만 입력(사업자 번호, 전화번호)
        private void textNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        
    }
}
