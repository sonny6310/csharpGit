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
    public partial class ChangeMyPW : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        //기업회원: COM_CUSTOMER 테이블 사용, 개인회원: CUSTOMER 테이블 사용
        string table;

        public ChangeMyPW(string table)
        {
            InitializeComponent();
            this.table = table;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (table == "COM_CUSTOMER") // 기업회원
            {
                if (text_currentPW.Text.Equals(MainForm.getPW())) // 현재 비밀번호 맞을 때
                {
                    if (text_changePW.Text.Equals(text_check.Text)) // 바꿀비밀번호랑 비밀번호 체크랑 맞을 때
                    {
                        SqlConnection sqlcon = new SqlConnection(DBConnection.strconn);
                        try
                        {
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand("update COM_CUSTOMER set PW = @pw where ID = @id", sqlcon);
                            cmd.Parameters.AddWithValue("@pw", text_changePW.Text);
                            cmd.Parameters.AddWithValue("@id", MainForm.getID());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("변경이 완료되었습니다.\r\n다시 로그인 해 주세요");
                            Log.printLog("기업회원 비밀번호 변경 완료");
                        }
                        catch (Exception)
                        {
                            Log.printLog("기업회원 비밀번호 변경 에러");
                            MessageBox.Show("에러");
                        }
                        finally
                        {
                            if(sqlcon!=null)
                                sqlcon.Close();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("바꿀 비밀번호 확인이 맞지 않습니다. 다시 입력 해 주세요");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀립니다. 다시 입력 해 주세요");
                }
            }
            else // 개인회원
            {
                if (text_currentPW.Text.Equals(IMemberMainForm.getPW())) // 현재 비밀번호 맞을 때
                {
                    if (text_changePW.Text.Equals(text_check.Text)) // 바꿀비밀번호와 비밀번호 체크가 맞을 때
                    {
                        SqlConnection sqlcon = new SqlConnection(DBConnection.strconn);
                        try
                        {
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand("update CUSTOMER set PW = @pw where ID = @id", sqlcon);
                            cmd.Parameters.AddWithValue("@pw", text_changePW.Text);
                            cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("변경이 완료되었습니다.\r\n다시 로그인 해 주세요");
                            Log.printLog("개인회원 비밀번호 변경 완료");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("변경에 실패했습니다.");
                            Log.printLog("개인회원 비밀번호 변경 에러");
                        }
                        finally
                        {
                            if(sqlcon!=null)
                                sqlcon.Close();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("바꿀 비밀번호 확인이 맞지 않습니다. 다시 입력 해 주세요");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀립니다. 다시 입력 해 주세요");
                }
            }
        }

        private void ChangeMyPW_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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
