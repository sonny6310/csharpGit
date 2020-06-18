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

namespace Apartment
{
    public partial class Form1 : Form
    {
        string loginConn = "Data Source=192.168.0.200;Initial Catalog=jh_20200611;Persist Security Info=True;User Id=sa;Password=8765432!";

        public Form1()
        {
            InitializeComponent();
        }

        private void login_click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(loginConn);

            SqlCommand sc = new SqlCommand("select ID, PW from login");
            sc.Connection = sqlcon;
            sqlcon.Open();

            SqlDataReader dr = sc.ExecuteReader();

            while (dr.Read())
            {
                if(dr["ID"].ToString() == tb_id.Text && dr["PW"].ToString() == tb_pw.Text)
                {
                    new Form2().ShowDialog();
                }else
                {
                    lb_loginInfo.Text = "ID 혹은 PW를 틀리셨습니다.";
                    lb_loginInfo.ForeColor = Color.Red;
                    lb_loginInfo.Location = new Point(70, 91);
                }
            }
            sqlcon.Close();
        }

        private void formClose_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_keyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)   // 엔터 누르면 로그인버튼 눌림
            {
                login_click(sender, e);
            }
            
            if(e.KeyCode == Keys.Escape)  // esc 누르면 종료버튼 눌림
            {
                formClose_click(sender, e);
            }
        }
    }
}
