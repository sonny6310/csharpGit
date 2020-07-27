using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Company.ManagePost
{
    public partial class show_resume_this_application : Form
    {
        DataRow dr;
        public show_resume_this_application(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
        }

        private void show_resume_this_application_Load(object sender, EventArgs e)
        {
            label_name.Text = dr["name"].ToString();
            label_email.Text = dr["email"].ToString();
            label_phone.Text = dr["phone"].ToString();
            label_addr.Text = dr["addr"].ToString();
            label_license.Text = dr["license"].ToString();
            label_exp.Text = dr["exp"].ToString();
            label_subject.Text = dr["re_subject"].ToString();
            label_content.Text = dr["content"].ToString();
        }
    }
}
