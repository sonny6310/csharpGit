using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Individual.Review;
using System.Data.SqlClient;

namespace Login
{
    public partial class IMenu4 : UserControl
    {
        public IMenu4()
        {
            InitializeComponent();
        }
        private void IMenu4_Load(object sender, EventArgs e)
        {
            ShowListDB();
        }
        SqlConnection conn = new SqlConnection();
        string r_num;

        // 리스트박스 DB보여주기
        public void ShowListDB()
        {
            try
            {
                conn.ConnectionString = DBConnection.strconn;

                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                Console.WriteLine("i menu4 showDB 호출");                                     // 테스트
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select rev_Num,rev_comName,rev_subject, content,r_date,rev_STAR_PT from review";
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        listView1.Items.Add(new ListViewItem(new string[]
                            {
                            DR["rev_Num"].ToString(),
                            DR["rev_comName"].ToString(),
                            DR["rev_subject"].ToString(),
                            DR["content"].ToString(),
                            DR["r_date"].ToString(),
                            DR["rev_STAR_PT"].ToString()
                            }));
                    }
                }
                DR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("showDB Error");                      // 에러메세지
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
            finally
            {
                conn.Close();
            }
        }

        // 선택한값 r_num 지정
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            try
            {
                ListViewItem item = listView1.SelectedItems[0];

                Console.WriteLine("선택한 글 번호 : " + item.SubItems[0].Text);   // 테스트
                r_num = item.SubItems[0].Text;
                Console.WriteLine("선택한 글 번호 r_num : " + r_num);   // 테스트
            }
            catch (Exception ex)
            {
                Console.WriteLine("listview_SelectedIndexChanged Error");                   // 에러메세지
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                conn.Close();
            }
        }

        // 후기 작성 버튼 클릭
        private void btn_write_review_Click(object sender, EventArgs e)
        {
            Select_Review_for_Writing srfw = new Select_Review_for_Writing();
            srfw.MaximizeBox = false;
            srfw.MinimizeBox = false;
            srfw.ShowDialog();
        }

        // 후기 자세히보기 버튼 클릭
        private void btn_show_rev_detail_Click(object sender, EventArgs e)
        {
            show_review_detail();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            show_review_detail();
        }
        private void show_review_detail()
        {
            try
            {
                if (r_num != null)
                {
                    Console.WriteLine("r_num = " + r_num);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    DataSet ds = new DataSet();
                    SqlDataAdapter adpt = new SqlDataAdapter("select * from review where rev_num=" + r_num, conn);
                    adpt.Fill(ds);
                    View_Review vr = new View_Review(ds);
                    vr.MaximizeBox = false;
                    vr.MinimizeBox = false;
                    vr.Show();
                }
                else
                {
                    MessageBox.Show("글을 선택해주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미 삭제된 글입니다. \n새로고침하세요.");
            }
        }

        // 전체 후기 보기
        private void btn_All_review_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ShowListDB();
        }
        // 내 후기 보기
        private void btn_My_Review_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            show_My_review();
        }
        private void show_My_review()
        {
            try
            {
                conn.ConnectionString = DBConnection.strconn;

                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                Console.WriteLine("showDB 호출");                                     // 테스트
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select rev_Num,rev_comName,rev_subject, content,r_date,rev_STAR_PT from review where rev_id = @r_id";
                cmd.Parameters.AddWithValue("@r_id", IMemberMainForm.getID());
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        listView1.Items.Add(new ListViewItem(new string[]
                            {
                            DR["rev_Num"].ToString(),
                            DR["rev_comName"].ToString(),
                            DR["rev_subject"].ToString(),
                            DR["content"].ToString(),
                            DR["r_date"].ToString(),
                            DR["rev_STAR_PT"].ToString()
                            }));
                    }
                }
                DR.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("showDB Error");                      // 에러메세지
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
