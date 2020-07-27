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
    public partial class View_Review : Form
    {
        DataRow dr;
        SqlConnection conn = new SqlConnection();
        string r_num;
        public View_Review(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
        }
        private void View_Review_Load(object sender, EventArgs e)
        {
            // 로그인아이디와 글작성아이디가 같으면 삭제버튼이 생긴다
            if (dr["rev_id"].Equals(IMemberMainForm.getID()))
            {
                btn_delete_review.Visible = true;
            }

            Console.WriteLine("로그인한아이디 = "+IMemberMainForm.getID());
            Console.WriteLine("글 작성 아이디 = "+dr["rev_id"]);
            label_rev_subject.Text = dr["rev_subject"].ToString();
            label_rev_content.Text = dr["content"].ToString();
            label_rev_num.Text = dr["rev_num"].ToString();
            r_num = label_rev_num.Text;
            label_rev_field.Text = dr["rev_field"].ToString();
            label_rev_comName.Text = dr["rev_comName"].ToString();
            switch (dr["rev_STAR_PT"].ToString())
            {
                case "1":
                    label_rev_rate_pic.Size = new Size(25, 20);
                    break;
                case "2":
                    label_rev_rate_pic.Size = new Size(49, 20);
                    break;
                case "3":
                    label_rev_rate_pic.Size = new Size(74, 20);
                    break;
                case "4":
                    label_rev_rate_pic.Size = new Size(98, 20);
                    break;
                case "5":
                    label_rev_rate_pic.Size = new Size(123,20);
                    break;
                default:
                    break;
            }
            label_rev_place.Text = dr["rev_place"].ToString();
            DateTime w_date = (DateTime)dr["r_date"];
            label_rev_date.Text = w_date.ToString("yyyy/MM/dd");
        }

        // 뒤로가기 버튼 클릭
        private void btn_back_click(object sender, EventArgs e)
        {
            Close();
        }

        // 삭제버튼 클릭
        private void btn_delete_review_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까 ", "글 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_review();
            }
            else
            {
                Close();
            }
        }

        private void delete_review()
        {
            // 의미없는 if지만 혹시모를 변수를 위해 삭제안함
            if (dr["rev_id"].Equals(IMemberMainForm.getID()))
            {
                conn.ConnectionString = DBConnection.strconn;
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from review where rev_num = @r_num";
                cmd.Parameters.AddWithValue("@r_num", r_num);
                cmd.ExecuteNonQuery();
                conn.Close();
                Log.printLog("후기 삭제 완료");
                Close();
                MessageBox.Show("삭제 완료");
            }
            else
            {
                MessageBox.Show("자신이 작성한 글만 삭제할 수 있습니다.");
            }
        }

    }
}
