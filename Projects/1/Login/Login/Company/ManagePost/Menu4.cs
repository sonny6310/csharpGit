using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login.Recruit;
using Login.Company.ManagePost;
using Login.PostRecruit;

namespace Login
{
    public partial class Menu4 : UserControl
    {
        // RECRUIT table에서 로그인 아이디와 일치하는 글 select where id=?? 로 입력 받기

        SqlConnection conn = new SqlConnection();
        private string userid;
        
        string w_num;       // 글번호 입력받을 변수
        string a_count_num; // 지원자수
        public Menu4()
        {
            InitializeComponent();
            userid = MainForm.getID();
        }
        private void Menu4_Load(object sender, EventArgs e)
        {
            refresh_listview();
        }
        // 새로고침
        public void refresh_listview()
        {
            listView1.Items.Clear();    // 리스트뷰 목록 삭제
            ShowListDB();                   // 리스트박스 입력
            conn.Close();
            Console.WriteLine("새로고침됨");                                     // 테스트
            Console.WriteLine("접속한 ID = " + MainForm.getID());
        }

        // DB 연결
        private void ConnectDB()
        {
            conn.ConnectionString = DBConnection.strconn;

            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
            Console.WriteLine("ConnectDB() 호출 성공");         // 테스트
        }

        // 리스트박스 DB보여주기
        public void ShowListDB()
        {
            try
            {
                Console.WriteLine("menu4 showDB 호출");                                     // 테스트
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select w_num,id,subject,w_content,w_date,count,a_count from RECRUIT where id = @id";
                cmd.Parameters.AddWithValue("@id", userid);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        listView1.Items.Add(new ListViewItem(
                            new string[]
                            {
                            DR["w_num"].ToString(),
                            DR["ID"].ToString(),
                            DR["SUBJECT"].ToString(),
                            DR["W_CONTENT"].ToString(),
                            DR["W_DATE"].ToString(),
                            DR["COUNT"].ToString(),
                            DR["a_count"].ToString()
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
                Console.WriteLine("showDB ConnClose");
                conn.Close();
            }

        }

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
                w_num = item.SubItems[0].Text;
                Console.WriteLine("선택한 글 지원자 수 : "+item.SubItems[6].Text);
                a_count_num = item.SubItems[6].Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("listview_SelectedIndexChanged Error");                   // 에러메세지
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }
        // 자세히보기 버튼 클릭
        private void btn_show_detail_Click(object sender, EventArgs e)
        {
            show_detail(w_num);
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            show_detail(w_num);
        }

        // 자세히보기 버튼 클릭 Recruit 안 WriteDetail.cs 호출
        private void show_detail(string num)
        {
            try
            {
                if (w_num != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    DataSet ds = new DataSet();
                    cmd.CommandText = "select * from RECRUIT where W_NUM= @W_NUM";
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@W_NUM", w_num);
                    adpt.Fill(ds);
                    WriteDetail wd = new WriteDetail(ds);
                    
                    wd.MaximizeBox = false;         // WriteDetail 호출시 최소화,최대화 버튼 삭제
                    wd.MinimizeBox = false;
                    wd.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("btn_show_detail_click Error");                       // 에러메세지
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                conn.Close();
            }
        }

        // 수정하기 버튼 클릭
        private void btn_edit_detail_Click(object sender, EventArgs e)
        {
            if (w_num != null)
            {
                Edit_post_detail edit = new Edit_post_detail(w_num);
                edit.ShowDialog();
                refresh_listview();
            }
        }

        // 새로고침 버튼 클릭
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_listview();
        }

        // 공고삭제 버튼 클릭
        private void btn_delete_post_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까 ", "공고 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (w_num != null)
                {
                    delete_post(w_num);
                }
                else
                {
                    MessageBox.Show("삭제 할 글을 선택하세요");
                }
            }
        }
        public void delete_post(string num)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from RECRUIT where w_num = @w_num";
            cmd.Parameters.AddWithValue("@w_num", num);
            cmd.ExecuteNonQuery();
            conn.Close();
            refresh_listview();
        }
        // 지원자보기 클릭
        private void show_applier_Click(object sender, EventArgs e)
        {
            if (a_count_num == "0")
            {
                MessageBox.Show("지원자가 없습니다.");
            }
            else if (w_num != null)
            {
                ApplicationList AL = new ApplicationList(w_num);
                AL.ShowDialog();
            }
        }
    }
}
