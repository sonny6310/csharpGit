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

namespace Login.Company.ManagePost
{
    public partial class ApplicationList : Form
    {
        //DB연결
        string strconn = DBConnection.strconn;
        string w_num;
        string user_id_store;
        public ApplicationList(string w_num)
        {
            InitializeComponent();
            this.w_num = w_num;
            lb_w_num.Text = "No. " + w_num.ToString();
        }

        SqlConnection sqlcon;
        private void ApplicantList_Load(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from A_LIST where W_NUM = @w_num",sqlcon);
                cmd.Parameters.AddWithValue("@w_num", w_num);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                init_list_setting(ds.Tables[0]);
                sqlcon.Close();
                Log.printLog("지원자 리스트 로드 성공");
            }
            catch(Exception ee)
            {
                Log.printLog("지원자 리스트 로드 실패");
                Console.WriteLine(ee.StackTrace);
            }
        }

        private void init_list_setting(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string[] addr = row["A_ADDR"].ToString().Split(' ');
                string addr_convert;
                if (addr.Length < 2)
                {
                    addr_convert = addr[0];
                }
                else
                {
                    addr_convert = addr[0] + " " + addr[1];
                }
                dataGridView1.Rows.Add(row["A_ID"], row["A_NAME"], row["A_PHONE"], addr_convert);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                DataGridViewRow DVR = dataGridView1.SelectedRows[0];

                Console.WriteLine("선택한 이력서 : " + DVR.Cells[0].Value.ToString());   // 테스트
                user_id_store = DVR.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }
        // 데이터 더블클릭시 이력서 호출
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (w_num != null)
                {
                    sqlcon = new SqlConnection(strconn);
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from resume where id = @id", sqlcon);
                    cmd.Parameters.AddWithValue("@id", user_id_store);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(ds);
                    show_resume_this_application srta = new show_resume_this_application(ds);
                    srta.MaximizeBox = false;
                    srta.MinimizeBox = false;
                    srta.ShowDialog();
                    Log.printLog("이력서 호출 성공");

                }
            }
            catch (Exception ex)
            {
                Log.printLog("이력서 호출 실패");
                Console.WriteLine("btn_show_detail_click Error");                       // 에러메세지
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                sqlcon.Close();
            }
        }


    }


}
