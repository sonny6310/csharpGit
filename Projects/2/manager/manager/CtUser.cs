using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class CtUser : UserControl
    {

        public CtUser(DataRow dr, List<string[]> menu)
        {
            InitializeComponent();

            lbPcNum.Text = dr["PC_Num"].ToString();
            lbTime.Text = dr["Order_Time"].ToString();
            lbMoney.Text = dr["Payment"].ToString();
            if (dr["card"].ToString() == "1")
            {
                lbPayment.Text = "카드";

            }
            else
            {
                lbPayment.Text = "현금";
            }
            if (dr["cachKinds"].ToString() == "")
            {
                lbcash.Text = "카드결제";
            }
            else
            {
                lbcash.Text = dr["cachKinds"].ToString();

            }
            lbMemo.Text = dr["memo"].ToString();

            foreach (string[] item in menu)
            {
                Console.WriteLine(item[0].ToString());
                dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString());
            }
            dataGridView1.Show();
            Console.WriteLine("------------------");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect();

            DialogResult dr = MessageBox.Show("음식 전달이 완료되었습니까?", "알림", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                db.updateEnd(lbTime.Text, lbPcNum.Text);
                this.Dispose();
            }

        }

        private void CtUser_Load(object sender, EventArgs e)
        {


        }

        private void GetInfo(string pcNum, string time, int money, string payment, int cash, string memo)
        {
            lbPcNum.Text = pcNum;
            lbTime.Text = time;
            lbMoney.Text = Convert.ToString(money);
            lbPayment.Text = payment;
            lbcash.Text = Convert.ToString(cash);
            lbMemo.Text = memo;
        }
    }
}
