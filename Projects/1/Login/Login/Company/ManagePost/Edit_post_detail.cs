using Login.Recruit;
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
    public partial class Edit_post_detail : Form
    {
        public Edit_post_detail()
        {
            InitializeComponent();
        }
        private string r_num;       // 변수 선언

        public Edit_post_detail(string num)
        {
            InitializeComponent();
            Console.WriteLine("show_post_detail 전달 받은 값 : " + num);         // 테스트
            r_num = num;        // 전달값 변수 초기화
            show_edit_detail(num);
        }

        SqlConnection conn = new SqlConnection();

        // DB 연결
        private void ConnectDB()
        {
            conn.ConnectionString = DBConnection.strconn;

            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
            Console.WriteLine("DB 연결 성공 from (Show_Post_detail)");
        }

        // 입력된 정보 수정 위해 호출
        private void show_edit_detail(string num)
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from RECRUIT where w_num = @w_num";
            cmd.Parameters.AddWithValue("@w_num", num);
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT where w_num =" + num, conn);
            adpt.Fill(ds);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    txtb_w_num.Text = DR["w_num"].ToString();
                    txtb_w_ID.Text = DR["id"].ToString();
                    txtb_w_pay.Text = DR["pay"].ToString();
                    txtb_w_place.Text = DR["w_place"].ToString();
                    txtb_w_subject.Text = DR["subject"].ToString();
                    txtb_w_content.Text = DR["w_content"].ToString();
                    txtb_w_field.Text = DR["field"].ToString();
                    DateTime w_time_from = (DateTime)DR["w_start_time"];
                    datetimeP_From.Value = w_time_from;
                    DateTime w_time_to = (DateTime)DR["w_end_time"];
                    datetimeP_To.Value = w_time_to;
                    DateTime w_time_finish = (DateTime)DR["period"];
                    datetime_finish.Value = w_time_finish;
                }
            }
            DR.Close();
        }

        Menu4 m4 = new Menu4();

        // 수정완료 버튼 클릭
        private void btn_confirm_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 수정하시겠습니까 ", "공고 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            confirm_edit();
            }
            else
            {
                Close();
            }
        }
        private void confirm_edit()
        {
            try
            {
                Console.WriteLine("수정 버튼 누를때 전달값 " + r_num);
                SqlCommand cmd = new SqlCommand("update RECRUIT " +
                                            "set " +
                                            "pay = @pay, " +
                                            "w_place=@w_place, " +
                                            "subject =@subject, " +
                                            "w_content =@w_content, " +
                                            "field =@field, " +
                                            "w_start_time =@w_start_time, " +
                                            "w_end_time =@w_end_time, " +
                                            "period =@period " +
                                            "where w_num = @w_num", conn);
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@w_num", r_num);
                cmd.Parameters.AddWithValue("@pay", txtb_w_pay.Text);
                cmd.Parameters.AddWithValue("@w_place", txtb_w_place.Text);
                cmd.Parameters.AddWithValue("@subject", txtb_w_subject.Text);
                cmd.Parameters.AddWithValue("@w_content", txtb_w_content.Text);
                cmd.Parameters.AddWithValue("@field", txtb_w_field.Text);
                cmd.Parameters.AddWithValue("@w_start_time", datetimeP_From.Value);
                cmd.Parameters.AddWithValue("@w_end_time", datetimeP_To.Value);
                cmd.Parameters.AddWithValue("@period", datetime_finish.Value);

                cmd.ExecuteNonQuery();

                Log.printLog("공고 수정 성공");
                Close();
            }
            catch (Exception ex)
            {
                Log.printLog("공고 수정 오류");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        // 취소버튼 클릭
        private void btn_edit_cancel_click(object sender, EventArgs e)
        {
            Close();
        }
        // 폼 닫힐때 리스트뷰 새로고침
        private void Edit_post_detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            m4.refresh_listview();
        }

    }
}
