using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm // 부모폼 변경
    {
        string strconn = "Data Source=192.168.0.200;Initial Catalog=jh_20200611;Persist Security Info=True;User Id=sa;Password=8765432!";

        public Form1()
        {
            InitializeComponent();

            this.Text = "MS SQL DB 연습";

            // material skin
            // https://ourcodeworld.com/articles/read/441/how-to-use-material-design-controls-with-c-in-your-winforms-application
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);


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
                //MessageBox.Show($"선택한 값: {dataGridView1[e.ColumnIndex, e.RowIndex].Value}");

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

        // ex) A버튼 클릭 시 B에서 이벤트 발생하도록 하기 위해서 설정
        private bool insertClicked = false;
        private bool updateClicked = false;
        private bool deleteClicked = false;

        private void insert_click(object sender, EventArgs e)
        {
            tb_id.ReadOnly = true;
            tb_name.BackColor = Color.SkyBlue;
            tb_age.BackColor = Color.SkyBlue;
            tb_temp.BackColor = Color.SkyBlue;
            insertClicked = true;
        }

        private void update_click(object sender, EventArgs e)
        {
            tb_id.BackColor = Color.Thistle;
            tb_name.BackColor = Color.Thistle;
            tb_age.BackColor = Color.Thistle;
            tb_temp.BackColor = Color.Thistle;
            updateClicked = true;
        }

        private void delete_click(object sender, EventArgs e)
        {
            tb_id.BackColor = Color.DarkSeaGreen;
            tb_name.BackColor = Color.DarkSeaGreen;
            tb_age.BackColor = Color.DarkSeaGreen;
            tb_temp.BackColor = Color.DarkSeaGreen;
            deleteClicked = true;
        }

        private void deleteAll_click(object sender, EventArgs e)
        {
            tb_id.BackColor = Color.Wheat;
            tb_name.BackColor = Color.Wheat;
            tb_age.BackColor = Color.Wheat;
            tb_temp.BackColor = Color.Wheat;

            WriteLog("DeleteAll 버튼 클릭");

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            DialogResult result = MessageBox.Show($"정말로 MemberTable의 모든 데이터를 지우시겠습니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from MemberTable", sqlcon);
                cmd.ExecuteNonQuery();

                // identity(1,1) (1부터 1씩 자동으로 증가  ::  oracle에서 seq) 을 초기화 하기
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(MemberTable, reseed, 0)", sqlcon);
                cmd2.ExecuteNonQuery();
            }

            sqlcon.Close();

            selectQuery();

            tb_id.BackColor = Color.White;
            tb_name.BackColor = Color.White;
            tb_age.BackColor = Color.White;
            tb_temp.BackColor = Color.White;
        }

        private void randData_click(object sender, EventArgs e)
        {
            WriteLog("RandData 버튼 클릭");

            tb_id.BackColor = SystemColors.ControlDark;
            tb_name.BackColor = SystemColors.ControlDark;
            tb_age.BackColor = SystemColors.ControlDark;
            tb_temp.BackColor = SystemColors.ControlDark;

            DialogResult result = MessageBox.Show("랜덤데이터 5개를 생성합니다", "랜덤데이터", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(result == DialogResult.OK)
            {
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

            tb_id.BackColor = Color.White;
            tb_name.BackColor = Color.White;
            tb_age.BackColor = Color.White;
            tb_temp.BackColor = Color.White;
        }

        private void btn_check(object sender, EventArgs e)
        {
            if (insertClicked)
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
                        int.TryParse(tb_age.Text, out age);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                        cmd.ExecuteNonQuery();
                    }

                    sqlcon.Close();

                    selectQuery();

                    tb_id.ReadOnly = false;
                    insertClicked = false;
                }
                catch (Exception except)
                {
                    MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace);
                }

            }

            if (updateClicked)
            {
                WriteLog("Update 버튼 클릭");

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update MemberTable set Name = @name, age = @age, rgdate = getdate(), bigo = @bigo where ID = @ID", sqlcon);

                int age;
                int.TryParse(tb_age.Text, out age);

                if (tb_name.Text == "" && tb_age.Text == "" && tb_temp.Text == "")
                {

                    DialogResult result = MessageBox.Show($"정말로 ID={tb_id.Text}의 데이터를 초기화 하시겠습니까?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@ID", tb_id.Text);
                        cmd.Parameters.AddWithValue("@name", tb_name.Text);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID", tb_id.Text);
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@bigo", tb_temp.Text);
                    cmd.ExecuteNonQuery();
                }

                sqlcon.Close();

                selectQuery();

                updateClicked = false;
            }

            if (deleteClicked)
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

                deleteClicked = false;
            }

            tb_id.BackColor = Color.White;
            tb_name.BackColor = Color.White;
            tb_age.BackColor = Color.White;
            tb_temp.BackColor = Color.White;
            tb_id.Clear();
            tb_name.Clear();
            tb_age.Clear();
            tb_temp.Clear();
        }

        //숫자와 백스페이스만 입력되게 하는 메소드
        private void onlyNumber(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    
            {
                e.Handled = true;
            }
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(e);
        }

        private void tb_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(e);
        }
    }
}
