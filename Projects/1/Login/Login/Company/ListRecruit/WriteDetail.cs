using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Recruit
{
    public partial class WriteDetail : Form
    {
        DataRow dr;
        public WriteDetail(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
            
        }
        
        private void btn_뒤로가기_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // RECRUIT 테이블에 있는 정보를 뿌려줌
        private void WriteDetail_Load(object sender, EventArgs e)
        {
            lb_subject.Text = (string)dr["subject"];
            lb_com_name.Text = (string)dr["COM_NAME"];
            lb_field.Text = (string)dr["FIELD"];
            int pay = (int)dr["PAY"];
            string pay_convert = string.Format("{0}", pay.ToString("#,##0"))+" 원";
            lb_pay.Text = pay_convert;

            DateTime w_date = (DateTime)dr["W_DATE"];
            lb_w_date.Text = w_date.ToString("yyyy/MM/dd");

            DateTime w_period = (DateTime)dr["PERIOD"];
            lb_period.Text= w_period.ToString("yyyy/MM/dd");

            DateTime w_start_time = (DateTime)dr["W_START_TIME"];
            DateTime w_end_time = (DateTime)dr["W_END_TIME"];
            string start_time = w_start_time.ToString("MM") + "월 " + w_start_time.ToString("dd") + "일 " ;
            string end_time = w_end_time.ToString("MM") + "월 " + w_end_time.ToString("dd") + "일 ";
            lb_time.Text = start_time+ " ~ "+end_time;

            lb_w_place.Text = (string)dr["W_PLACE"];
            lb_w_content.Text = (string)dr["W_CONTENT"];

            lb_id.Text = (string)dr["NAME"];

        }
    }
}
