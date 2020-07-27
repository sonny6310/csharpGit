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
using System.Runtime.InteropServices;
using System.Drawing.Text;
using Login.Recruit;
using System.Security.Cryptography.X509Certificates;

namespace Login
{
    
    public partial class Menu2 : UserControl
    {
        private Button currentButton; //현재 정렬 버튼 확인
        private string search_keyword; //검색데이터
        private bool search_on = false; //검색중인지 확인
        private static Menu2 menu2;
        //DB연결
        string strconn = DBConnection.strconn;

        //컨트롤 둥글게 만들기 위해 참조
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
        
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public Menu2()
        {
            InitializeComponent();
            
        }
        public static void setInstance(Menu2 m2)
        {
            menu2 = m2;
        }
        public static Menu2 getInstance()
        {
            if (menu2 == null)
            {
                menu2 = new Menu2();
            }
            
            return menu2;
        }
        private void Menu2_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Font = new Font("HY강M", 10, FontStyle.Regular);
            //검색창 테두리 둥글게
            IntPtr tbRound = CreateRoundRectRgn(0, 0, panel_search.Width, panel_search.Height, 15, 15);
            int i = SetWindowRgn(panel_search.Handle, tbRound, true);
            //정렬버튼 테두리 둥글게
            buttonInitSetting();
            this.Refresh();

            //처음 켜질 때는 전체글 버튼 셋팅
            ActivateButton(btn_allSearch);

            //목록 뿌리기
            selectData();

        }
        private void buttonInitSetting()
        {
            //정렬버튼 테두리 둥글게
            IntPtr btnAllSearchRound = CreateRoundRectRgn(0, 0, btn_allSearch.Width, btn_allSearch.Height, 15, 15);
            int i2 = SetWindowRgn(btn_allSearch.Handle, btnAllSearchRound, true);
            IntPtr btn_comSearchRound = CreateRoundRectRgn(0, 0, btn_comSearch.Width, btn_comSearch.Height, 15, 15);
            int i3 = SetWindowRgn(btn_comSearch.Handle, btn_comSearchRound, true);
            IntPtr btn_countSearchRound = CreateRoundRectRgn(0, 0, btn_countSearch.Width, btn_countSearch.Height, 15, 15);
            int i4 = SetWindowRgn(btn_countSearch.Handle, btn_countSearchRound, true);
            IntPtr btn_subjectSearchRound = CreateRoundRectRgn(0, 0, btn_subjectSearch.Width, btn_subjectSearch.Height, 15, 15);
            int i5 = SetWindowRgn(btn_subjectSearch.Handle, btn_subjectSearchRound, true);
            IntPtr btn_paySearchRound = CreateRoundRectRgn(0, 0, btn_paySearch.Width, btn_paySearch.Height, 15, 15);
            int i6 = SetWindowRgn(btn_paySearch.Handle, btn_paySearchRound, true);
            IntPtr btn_w_placeSearchRound = CreateRoundRectRgn(0, 0, btn_w_placeSearch.Width, btn_w_placeSearch.Height, 15, 15);
            int i7 = SetWindowRgn(btn_w_placeSearch.Handle, btn_w_placeSearchRound, true);
            IntPtr btn_w_end_timeSearchRound = CreateRoundRectRgn(0, 0, btn_w_end_timeSearch.Width, btn_w_end_timeSearch.Height, 15, 15);
            int i8 = SetWindowRgn(btn_w_end_timeSearch.Handle, btn_w_end_timeSearchRound, true);

        }
        private void ActivateButton(object btnSender) //현재 버튼과 이전 버튼의 색상을 바꾸는 함수
        {
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = System.Drawing.Color.White;
                    currentButton.ForeColor = System.Drawing.Color.Gray;
                }
                currentButton = (Button)btnSender;
                currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
                currentButton.ForeColor = System.Drawing.Color.White;
            }
        }
        public void selectData() //글 번호 순서(내림차순)로 전체 글 읽는 함수
        {

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "All");
                cmd.Parameters.AddWithValue("@search_on", "false");
                cmd.Parameters.AddWithValue("@search_choice", "false");
                cmd.Parameters.AddWithValue("@search_keyword", "null");
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }

        }
        private void selectData(string str) //검색 데이터를 읽는 함수
        {
            if (str.Equals(""))
            {
                selectData();
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                try
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                    cmd.Parameters.AddWithValue("@order_col_name", "partialSearch");
                    cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                    cmd.Parameters.AddWithValue("@search_choice", "false");
                    cmd.Parameters.AddWithValue("@search_keyword", str);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(ds);

                    dataGridView1.Rows.Clear();
                    gridViewSetting(ds.Tables[0]);
                }
                catch 
                {
                    MessageBox.Show("에러");
                }
                finally
                {
                    if(sqlcon!=null)
                        sqlcon.Close();
                }
            }
        }

        // 검색 아이콘 클릭 시 검색 여부 true로 바꾸고 검색 단어 받아두고 검색하는 함수 불러줌
        private void btn_search_Click(object sender, EventArgs e) 
        {
            search_on = true;
            search_keyword = tb_search.Text;
            selectData(search_keyword);
        }

        // 전체 글 보기로 다시 바꿈, 검색 여부 false로 변경
        private void btn_allSearch_Click(object sender, EventArgs e)
        {
            selectData();
            ActivateButton(sender);
            search_on = false;
        }

        /*
         * 모든 정렬하는 함수에 있는 sql 구문은 MS SQL ListSearch 프로시저 안에 담겨있음
         * 매개변수는 테이블이름, 정렬하는 기준의 열이름, 검색 여부, 오름차순_내림차순 여부 이렇게 4개를 받게 되어있음
         * */
        private bool com_search_choice = true; // true면 업체명 오름차순, false면 내림차순
        private void btn_comSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "com_name");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", com_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);
                    if (com_search_choice == true)
                    {
                        com_search_choice = false;
                    }
                    else
                    {
                        com_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");
                    if (com_search_choice == true)
                    {
                        com_search_choice = false;
                    }
                    else
                    {
                        com_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
                ActivateButton(sender);
            }
        }
        
        private bool count_search_choice = true; //true면 조회수 내림차순, false면 오름차순
        private void btn_countSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try{
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "count");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", count_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);

                    if (count_search_choice == true)
                    {
                        count_search_choice = false;
                    }
                    else
                    {
                        count_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");

                    if (count_search_choice == true)
                    {
                        count_search_choice = false;
                    }
                    else
                    {
                        count_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
                ActivateButton(sender);
            }
        }
        
        private bool firstClick = false; //맨 처음 검색박스 클릭 시 안내 글자 사라짐
        private void tb_search_Click(object sender, EventArgs e)
        {
            if (firstClick == false)
            {
                firstClick = true;
                tb_search.Text = "";
            }
            
        }

        //셀 더블클릭 시 글 내용 자세히 보는 창 띄우는 함수
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int w_num = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();

                //글번호가 같은 데이터를 불러온 후 WriteDetail폼에 전달
                SqlCommand cmd = new SqlCommand("select * from RECRUIT where W_NUM = @w_num", sqlcon);
                cmd.Parameters.AddWithValue("@w_num", w_num);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                WriteDetail writedetail = new WriteDetail(ds);

                //조회수 증가
                cmd = new SqlCommand("RecruitCountPlus", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@w_num", ds.Tables[0].Rows[0]["W_NUM"]);
                cmd.ExecuteNonQuery();

                Log.printLog($"{w_num}번 글 조회");

                writedetail.TopLevel = false;
                writedetail.FormBorderStyle = FormBorderStyle.None;
                writedetail.Dock = DockStyle.Fill;
                this.Controls.Add(writedetail);
                writedetail.BringToFront();
                writedetail.Show();
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
        }

        private bool pay_search_choice = true; //true는 내림차순, false는 오름차순, 기본은 내림차순으로 설정
        private void btn_pay_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "pay");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", pay_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);
                    if (pay_search_choice == true)
                    {
                        pay_search_choice = false;
                    }
                    else
                    {
                        pay_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");
                    if (pay_search_choice == true)
                    {
                        pay_search_choice = false;
                    }
                    else
                    {
                        pay_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
                ActivateButton(sender);
            }
        }

        private bool w_place_search_choice = false; //false는 오름차순, true는 내림차순, 기본은 오름차순으로 설정
        private void btn_w_place_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "w_place");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", w_place_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);
                    if (w_place_search_choice == true)
                    {
                        w_place_search_choice = false;
                    }
                    else
                    {
                        w_place_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");
                    if (w_place_search_choice == true)
                    {
                        w_place_search_choice = false;
                    }
                    else
                    {
                        w_place_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
                ActivateButton(sender);
            }
        }

        private bool w_end_time_search_choice = false; //true면 내림차순, false면 오름차순, 기본은 오름차순으로 설정
        private void btn_w_end_time_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "w_end_time");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", w_end_time_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);
                    if (w_end_time_search_choice == true)
                    {
                        w_end_time_search_choice = false;
                    }
                    else
                    {
                        w_end_time_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");
                    if (w_end_time_search_choice == true)
                    {
                        w_end_time_search_choice = false;
                    }
                    else
                    {
                        w_end_time_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
                ActivateButton(sender);
            }
        }

        private bool subject_search_choice = false; //false면 오름차순, ture면 내림차순 기본은 제목 오름차순으로 설정
        private void btn_subjectSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("ListSearch", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", "RECRUIT");
                cmd.Parameters.AddWithValue("@order_col_name", "subject");
                cmd.Parameters.AddWithValue("@search_on", search_on.ToString());
                cmd.Parameters.AddWithValue("@search_choice", subject_search_choice.ToString());
                if (search_on == true)
                {
                    cmd.Parameters.AddWithValue("@search_keyword", search_keyword);
                    if (subject_search_choice == true)
                    {
                        subject_search_choice = false;
                    }
                    else
                    {
                        subject_search_choice = true;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search_keyword", "null");
                    if (subject_search_choice == true)
                    {
                        subject_search_choice = false;
                    }
                    else
                    {
                        subject_search_choice = true;
                    }
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
            }
            catch
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
                ActivateButton(sender);
            }
        }
        private void gridViewSetting(DataTable table)
        {
            foreach (DataRow viewData in table.Rows)
            {
                DateTime w_end_time = (DateTime)viewData["W_END_TIME"];
                string w_end_time_convert = w_end_time.ToString("MM") + "/" + w_end_time.ToString("dd") + "(" + w_end_time.ToString("ddd") + ")";
                int pay = (int)viewData["PAY"];
                string pay_convert = string.Format("{0}", pay.ToString("#,##0")) + " 원";
                string addr_convert = viewData["W_PLACE"].ToString();
                string[] addr_split = addr_convert.Split(' ');
                if (addr_split.Length < 2)
                {
                    addr_convert = addr_split[0];
                }
                else
                {
                    addr_convert = addr_split[0] + " " + addr_split[1];
                }
                dataGridView1.Rows.Add(viewData["W_NUM"], viewData["COM_NAME"], viewData["SUBJECT"], pay_convert.ToString(), addr_convert, w_end_time_convert, viewData["COUNT"]);
            }
        }
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_on = true;
                search_keyword = tb_search.Text;
                selectData(search_keyword);
                tb_search.Text = "";
            }
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터시 띵띵 소리나는거 제거
            if(e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e) // 새로고침
        {
            selectData();
        }
    }
}
