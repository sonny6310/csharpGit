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

namespace Crud
{
    public partial class Form1 : Form
    {
        string strconn = "Data Source=192.168.0.200;Initial Catalog=jh_20200611;Persist Security Info=True;User Id=sa;Password=8765432!";

        public Form1()
        {
            InitializeComponent();
            selectQuery();

            /*
             * MSSQL 
create table MemberTable (
ID int identity(1,1) not null,
Name nvarchar(50),
age int,
rgdate datetime,
bigo nvarchar(MAX),
Constraint PK_MemberTable Primary Key(ID)
)
             */
        }

        // bin - debug - logfolder - log.txt에 기록 저장됨
        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            LogWriter.PrintLog(logContents);
        }

        private void selectQuery()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Membertable ORDER BY len(id) asc, id asc;", sqlcon);
            adpt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show($"선택한 값: {dataGridView1[e.ColumnIndex, e.RowIndex].Value}");

                tb_id.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                tb_name.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                tb_age.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                tb_temp.Text = dataGridView1[4, e.RowIndex].Value.ToString();

                WriteLog($"선택한 값: {dataGridView1[e.ColumnIndex, e.RowIndex].Value}");
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void insert_click(object sender, EventArgs e)
        {
            try
            {
                WriteLog("Insert 버튼 클릭");

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();



                SqlCommand cmd = new SqlCommand("insert into MemberTable (Name,age,rgdate,bigo) values (@name,@age,getdate(),@bigo)", sqlcon);
                if (tb_name.Text == "" && tb_age.Text == "" && tb_temp.Text == "")
                {
                    MessageBox.Show("값을 입력하시오");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    int age;
                    cmd.Parameters.AddWithValue("@age", int.TryParse(tb_age.Text, out age));
                    cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();

                selectQuery();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

        private void update_click(object sender, EventArgs e)
        {
            WriteLog("Update 버튼 클릭");

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlCommand cmd = new SqlCommand("update MemberTable set Name = @name, age = @age, rgdate = getdate(), bigo = @bigo where ID = @ID", sqlcon);

            int age;

            if (tb_name.Text == "" && tb_age.Text == "" && tb_temp.Text == "")
            {

                DialogResult result = MessageBox.Show($"정말로 ID={tb_id.Text}의 데이터를 초기화 하시겠습니까?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@ID", tb_id.Text);
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@age", int.TryParse(tb_age.Text, out age));
                    cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                cmd.Parameters.AddWithValue("@ID", tb_id.Text);
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@age", int.TryParse(tb_age.Text, out age));
                cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                cmd.ExecuteNonQuery();
            }

            sqlcon.Close();

            selectQuery();
        }

        private void delete_click(object sender, EventArgs e)
        {
            WriteLog("Delete 버튼 클릭");

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            DialogResult result = MessageBox.Show($"정말로 ID={tb_id.Text}의 데이터를 지우시겠습니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from MemberTable where ID = @ID", sqlcon);
                cmd.Parameters.AddWithValue("@ID", tb_id.Text);
                cmd.ExecuteNonQuery();
            }

            sqlcon.Close();

            selectQuery();
        }

        private void deleteAll_click(object sender, EventArgs e)
        {
            WriteLog("DeleteAll 버튼 클릭");

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            DialogResult result = MessageBox.Show($"정말로 MemberTable의 모든 데이터를 지우시겠습니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from MemberTable", sqlcon);
                cmd.ExecuteNonQuery();
            }

            sqlcon.Close();

            selectQuery();
        }

        private void randData_click(object sender, EventArgs e)
        {
            WriteLog("RandData 버튼 클릭");

            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                for (int i = 0; i < 5; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into MemberTable (Name,age,rgdate,bigo) values (@name,@age,getdate(),@bigo)", sqlcon);
                    cmd.Parameters.AddWithValue("@name", RandData.getName());
                    cmd.Parameters.AddWithValue("@age", RandData.getAge());
                    cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();

                selectQuery();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
            }
        }

    }
}
