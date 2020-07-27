using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Individual.CompanyInfo;

namespace Login.Individual.JobRecruitment
{
      public partial class PostInfo : UserControl
      {

            static ApplyInfo ai = new ApplyInfo();

           

            public PostInfo()
            {
                  InitializeComponent();
            }

            private int infoPay2;

            public string Com_Name { get { return ComName.Text; } set { ComName.Text = value; } }
            public string Info_Field { get { return infoField.Text; } set { infoField.Text = value; } }
            public int Info_Pay { get { return infoPay2; } set { infoPay2 = value; infoPay.Text = string.Format("{0}", value.ToString("#,##0"))+ " 원"; } }
            public string Info_Place { get { return infoPlace.Text; } set { infoPlace.Text = value; } }
            public string Info_Start { get { return infoStart.Text; } set { infoStart.Text = value; } }
            public string Info_Finish { get { return infoFinish.Text; } set { infoFinish.Text = value; } }
            public string Info_Dead { get { return infoDead.Text; } set { infoDead.Text = value; } }
            public int write_num { get { return int.Parse(infownum.Text); } set { infownum.Text = value.ToString(); } }

            public static int getWnum()
            {
                  return ai.get_wnum;
            }
            public static string getCname()
            {
                  return ai.get_Cname;
            }
            public static string getCfield()
            {
                  return ai.get_Cfield;
            }
            public static int getCpay()
            {
                  return ai.get_Cpay;
            }
            public static string getCplace()
            {
                  return ai.get_Cplace;
            }
            private void PostInfo_Click(object sender, EventArgs e)
            {

                  ApplyCompany ac = new ApplyCompany();
                  ai.get_wnum = write_num;
                  ai.get_Cname = Com_Name;
                  ai.get_Cfield = Info_Field;
                  ai.get_Cpay = Info_Pay;
                  ai.get_Cplace = Info_Place;
                  ac.Show();
            }

            private void PostInfo_MouseEnter(object sender, EventArgs e)
            {

                  ComName.ForeColor = System.Drawing.Color.Gray;

            }

            private void PostInfo_MouseLeave(object sender, EventArgs e)
            {
                  ComName.ForeColor = System.Drawing.Color.Black;
            }
      }
}
