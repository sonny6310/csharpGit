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

namespace Login.Individual.Review
{
    public partial class Write_Review : Form
    {

        public Write_Review(string a_num)
        {
            InitializeComponent();
            txtb_rev_ID.Text = IMemberMainForm.getID();
            this.a_num = a_num;
            get_info();
        }
        SqlConnection conn = new SqlConnection();
        string a_num;
        int r_num;       // 리뷰 글 번호 입력받을 변수
        string w_num;
        private string review_ComName;  // 회사명
        private string review_Place;         // 근무지
        private string review_Field;          // 직종
        private string review_Rate;         // 평점
        private string review_Subject;       // 제목
        private string review_Content;      // 내용

        private void get_info()
        {
            try
            {
                conn.ConnectionString = DBConnection.strconn;
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select a_num,a_com_name,a_com_field,a_com_place,w_num from a_list where a_num = @a_num";
                cmd.Parameters.AddWithValue("@a_num", a_num);
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        a_num = DR["a_num"].ToString();
                        txtb_rev_comName.Text = DR["a_com_name"].ToString();
                        txtb_rev_field.Text = DR["a_com_field"].ToString();
                        txtb_rev_place.Text = DR["a_com_place"].ToString();
                        w_num = DR["w_num"].ToString();
                    }
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }


        // 리뷰작성 버튼 클릭
        private void btn_confirm_write_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 작성하시겠습니까 ", "후기 작성", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                confirm_review();
            }
            else
            {
                Close();
            }
        }
        private void confirm_review()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtb_rev_place.Text) || string.IsNullOrWhiteSpace(txtb_rev_field.Text) ||
                    string.IsNullOrWhiteSpace(txtb_rev_subject.Text) || string.IsNullOrWhiteSpace(txtb_rev_content.Text) ||
                    string.IsNullOrEmpty(txtb_rev_place.Text) || string.IsNullOrEmpty(txtb_rev_field.Text) ||
                    string.IsNullOrEmpty(txtb_rev_subject.Text) || string.IsNullOrEmpty(txtb_rev_content.Text))
                {
                    MessageBox.Show("양식에 맞게 모든 칸에 입력하세요");
                }
                else
                {
                    review_ComName = txtb_rev_comName.Text;
                    review_Place = txtb_rev_place.Text;
                    review_Field = txtb_rev_field.Text;
                    review_Rate = trackBar1.Value.ToString();
                    review_Subject = txtb_rev_subject.Text;
                    review_Content = txtb_rev_content.Text;
                    insert_review();
                }
            }
            catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }

        }
        
        // 리뷰 데이터 입력
        private void insert_review()
        {
            try
            {
                conn.ConnectionString = DBConnection.strconn;
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                Console.WriteLine("review DB 연결 성공");          // 테스트

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                /*
                cmd.CommandText = "select * from review where rev_num = (select max(rev_num) from review)";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int.TryParse(dr["rev_num"].ToString(), out r_num);
                r_num++;
                dr.Close();
                */
                cmd.CommandText = "insert into review (rev_num, w_num, rev_id, rev_comName,rev_place,rev_field, rev_subject, content, r_date, rev_star_pt) " +
                                                            "values(NEXT VALUE FOR REVIEW_NUMBER,@w_num,@r_id,@r_comName,@r_place,@r_field,@r_subject,@content,@r_date,@r_star);";
                cmd.Parameters.AddWithValue("@w_Num", w_num);
                cmd.Parameters.AddWithValue("@r_id", txtb_rev_ID.Text);
                cmd.Parameters.AddWithValue("@r_comName", review_ComName);
                cmd.Parameters.AddWithValue("@r_place", review_Place);
                cmd.Parameters.AddWithValue("@r_field", review_Field);
                cmd.Parameters.AddWithValue("@r_subject", review_Subject);
                cmd.Parameters.AddWithValue("@content", review_Content);
                cmd.Parameters.AddWithValue("@r_date", DateTime.Now);
                cmd.Parameters.AddWithValue("@r_star", review_Rate);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select * from COM_INFO where COM_NAME = @com_name";
                cmd.Parameters.AddWithValue("@com_name", review_ComName);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    cmd.CommandText = "update COM_INFO set STAR_PT = (select AVG(rev_STAR_PT) from REVIEW where rev_comName = (select COM_NAME from RECRUIT where W_NUM = @wnum)) where COM_NAME = @info_com_name";
                    cmd.Parameters.AddWithValue("@wnum", w_num);
                    cmd.Parameters.AddWithValue("@info_com_name", review_ComName);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                Log.printLog("후기 등록 완료");
                Close();

            }
            catch (Exception ex)
            {
                Log.printLog("후기 등록 실패");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("후기가 작성되었습니다.");
            }
        }

        // 취소버튼
        private void btn_cancel_write_Click(object sender, EventArgs e)
        {
            Close();
        }
        // 심심해서 만들어본 평점 별표 표시
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value.ToString() == "1")
            {
                star_1.Visible = true;
                star_2.Visible = false;
                star_3.Visible = false;
                star_4.Visible = false;
                star_5.Visible = false;
            }
            if (trackBar1.Value.ToString() == "2")
            {
                star_1.Visible = true;
                star_2.Visible = true;
                star_3.Visible = false;
                star_4.Visible = false;
                star_5.Visible = false;
            }
            if (trackBar1.Value.ToString() == "3")
            {
                star_1.Visible = true;
                star_2.Visible = true;
                star_3.Visible = true;
                star_4.Visible = false;
                star_5.Visible = false;
            }
            if (trackBar1.Value.ToString() == "4")
            {
                star_1.Visible = true;
                star_2.Visible = true;
                star_3.Visible = true;
                star_4.Visible = true;
                star_5.Visible = false;
            }
            if (trackBar1.Value.ToString() == "5")
            {
                star_1.Visible = true;
                star_2.Visible = true;
                star_3.Visible = true;
                star_4.Visible = true;
                star_5.Visible = true;
            }
        }
    }
}
