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

namespace DBRand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            
            
        }
        private int[] ho = { 101, 102, 103, 201, 202, 203, 301, 302, 303, 401, 402, 403, 501, 502, 503, 601, 602, 603, 701, 702, 703, 801, 802, 803, 901, 902, 903, 1001, 1002, 1003, 1101, 1102, 1103, 1201, 1202, 1203, 1301, 1302, 1303, 1401, 1402, 1403, 1501, 1502, 1503, 1601, 1602, 1603, 1701, 1702, 1703, 1801, 1802, 1803, 1901, 1902, 1903, 2001, 2002, 2003 };
        private string strconn = "Data Source=192.168.0.200;Initial Catalog=jh_20200611;Persist Security Info=True;User Id=sa;Password=8765432!";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < ho.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into resident (building, unit, head,member,contact,car1,car2,pets,baby,remark,reg_date) values (101,@unit,@name,@num,@phone,@car1,@car2,@pet,@baby,@remark,getdate())", sqlcon);
                    cmd.Parameters.AddWithValue("@unit", ho[i]);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@num", RandData.getMem_num());
                    cmd.Parameters.AddWithValue("@phone", RandData.getphone());
                    cmd.Parameters.AddWithValue("@car1", RandData.getCar());
                    cmd.Parameters.AddWithValue("@car2", RandData.getCar());
                    cmd.Parameters.AddWithValue("@pet", RandData.getPet());
                    cmd.Parameters.AddWithValue("@baby", RandData.getbaby());
                    cmd.Parameters.AddWithValue("@remark", "전입");
                    cmd.Parameters.AddWithValue("@ho", ho[i]);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < ho.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into resident (building, unit, head,member,contact,car1,car2,pets,baby,remark,reg_date) values (102,@unit,@name,@num,@phone,@car1,@car2,@pet,@baby,@remark,getdate())", sqlcon);
                    cmd.Parameters.AddWithValue("@unit", ho[i]);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@num", RandData.getMem_num());
                    cmd.Parameters.AddWithValue("@phone", RandData.getphone());
                    cmd.Parameters.AddWithValue("@car1", RandData.getCar());
                    cmd.Parameters.AddWithValue("@car2", RandData.getCar());
                    cmd.Parameters.AddWithValue("@pet", RandData.getPet());
                    cmd.Parameters.AddWithValue("@baby", RandData.getbaby());
                    cmd.Parameters.AddWithValue("@remark", "전입");
                    cmd.Parameters.AddWithValue("@ho", ho[i]);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < ho.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into resident (building, unit, head,member,contact,car1,car2,pets,baby,remark,reg_date) values (103,@unit,@name,@num,@phone,@car1,@car2,@pet,@baby,@remark,getdate())", sqlcon);
                    cmd.Parameters.AddWithValue("@unit", ho[i]);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@num", RandData.getMem_num());
                    cmd.Parameters.AddWithValue("@phone", RandData.getphone());
                    cmd.Parameters.AddWithValue("@car1", RandData.getCar());
                    cmd.Parameters.AddWithValue("@car2", RandData.getCar());
                    cmd.Parameters.AddWithValue("@pet", RandData.getPet());
                    cmd.Parameters.AddWithValue("@baby", RandData.getbaby());
                    cmd.Parameters.AddWithValue("@remark", "전입");
                    cmd.Parameters.AddWithValue("@ho", ho[i]);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < ho.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into resident (building, unit, head,member,contact,car1,car2,pets,baby,remark,reg_date) values (104,@unit,@name,@num,@phone,@car1,@car2,@pet,@baby,@remark,getdate())", sqlcon);
                    cmd.Parameters.AddWithValue("@unit", ho[i]);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@num", RandData.getMem_num());
                    cmd.Parameters.AddWithValue("@phone", RandData.getphone());
                    cmd.Parameters.AddWithValue("@car1", RandData.getCar());
                    cmd.Parameters.AddWithValue("@car2", RandData.getCar());
                    cmd.Parameters.AddWithValue("@pet", RandData.getPet());
                    cmd.Parameters.AddWithValue("@baby", RandData.getbaby());
                    cmd.Parameters.AddWithValue("@remark", "전입");
                    cmd.Parameters.AddWithValue("@ho", ho[i]);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < ho.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into resident (building, unit, head,member,contact,car1,car2,pets,baby,remark,reg_date) values (105,@unit,@name,@num,@phone,@car1,@car2,@pet,@baby,@remark,getdate())", sqlcon);
                    cmd.Parameters.AddWithValue("@unit", ho[i]);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@num", RandData.getMem_num());
                    cmd.Parameters.AddWithValue("@phone", RandData.getphone());
                    cmd.Parameters.AddWithValue("@car1", RandData.getCar());
                    cmd.Parameters.AddWithValue("@car2", RandData.getCar());
                    cmd.Parameters.AddWithValue("@pet", RandData.getPet());
                    cmd.Parameters.AddWithValue("@baby", RandData.getbaby());
                    cmd.Parameters.AddWithValue("@remark", "전입");
                    cmd.Parameters.AddWithValue("@ho", ho[i]);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }
    }
}
