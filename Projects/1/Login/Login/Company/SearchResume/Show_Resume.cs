using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Company
{
    public partial class Show_Resume : Form
    {
        DataRow dr;
        public Show_Resume(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
        }

        private void Show_Resume_Load(object sender, EventArgs e)
        {
            reName.Text = (string)dr["NAME"];
            rePhone.Text = (string)dr["PHONE"];
            reEmail.Text = (string)dr["EMAIL"];
            reAddr.Text = (string)dr["ADDR"];
            lb_sub.Text = (string)dr["RE_SUBJECT"];
            lb_loca.Text = (string)dr["LOCATION"];
            lb_lic.Text = (string)dr["LICENSE"];
            lb_ex.Text = (string)dr["EXP"];
            lb_cont.Text = (string)dr["CONTENT"];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
