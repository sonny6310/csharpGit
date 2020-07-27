using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login.Company;

namespace Login
{
    public partial class Menu3 : UserControl
    {
        //DB연결
        string strconn = DBConnection.strconn;
        public Menu3()
        {
            InitializeComponent();
            ShowDB();
        }
        string renum;

        //보여주기(셀렉트쿼리)
        public void ShowDB()
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select RE_NUM, NAME, RE_SUBJECT, LICENSE, EXP, ADDR from RESUME", sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            RESUMEInfo.Columns[0].Width = 45;
            RESUMEInfo.Columns[1].Width = 100;
            RESUMEInfo.Columns[2].Width = 450;
            RESUMEInfo.Columns[3].Width = 103;
            RESUMEInfo.Columns[4].Width = 102;
            RESUMEInfo.Columns[5].Width = 100;

            sqlcon.Close();
            RESUMEInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //전체보기
        private void btn_AllView_Click(object sender, EventArgs e)
        {
            ShowDB();
        }
        //기타버튼
        private void btn_CptView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%목%' or [EXP] like '%목%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_ElecView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%전%' or [EXP] like '%전%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_PipeView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%배%' or [EXP] like '%배%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_MoldView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%몰%' or [EXP] like '%몰%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_GasView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%가%' or [EXP] like '%가%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_TileView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%타%' or [EXP] like '%타%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_SashView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%새%' or [EXP] like '%새%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_TWView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%일용%' or [EXP] like '%일용%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }
        //데이터그리드뷰에서 정보선택시 이력서 출력
        private void RESUMEInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int re_num = int.Parse(RESUMEInfo[0, e.RowIndex].Value.ToString());

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();

                //글번호가 같은 데이터를 불러온 후 WriteDetail폼에 전달
                SqlCommand cmd = new SqlCommand("select * from RESUME where RE_NUM = @re_num", sqlcon);
                cmd.Parameters.AddWithValue("@re_num", re_num);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                Show_Resume sr = new Show_Resume(ds);

                //조회수 증가
                //cmd = new SqlCommand("RecruitCountPlus", sqlcon);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@re_num", ds.Tables[0].Rows[0]["RE_NUM"]);
                cmd.ExecuteNonQuery();

                Log.printLog($"{re_num}번 이력서 글 조회");

                sr.TopLevel = false;
                sr.FormBorderStyle = FormBorderStyle.None;
                sr.Dock = DockStyle.Fill;
                this.Controls.Add(sr);
                sr.BringToFront();
                sr.Show();
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }
        }

        private void show_resume_detail()
        {
            
            if (renum != null)
            {

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                Console.WriteLine("RE_NUM = " + renum);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from RESUME where RE_NUM=" + renum, sqlcon);
                adpt.Fill(ds);
                Show_Resume sr = new Show_Resume(ds);
                sr.Show();
            }
            else
            {
                MessageBox.Show("글을 선택해주세요");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDB();
        }
    }
}


