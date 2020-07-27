using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Individual.CompanyInfo
{
    public partial class InfoItem : UserControl
    {
        // 기업 정보가 담긴 폼
        public InfoItem()
        {
            InitializeComponent();
        }
        public string lb_COM_NAME { get { return lb_com_name.Text; } set { lb_com_name.Text = value; } }
        public string lb_FIELD { get { return lb_field.Text; } set { lb_field.Text = value; } }
        public double lb_POINT { 
            get { 
                return double.Parse(lb_point.Text); 
            } 
            set {
                if (value == 0)
                {
                    lb_point.Text = "-";
                }
                else
                {
                    lb_point.Text = value.ToString(); 
                }
            } 
        }
        public int lb_SALES { get { return int.Parse(lb_sales.Text); } set { lb_sales.Text = string.Format("{0}", value.ToString("#,##0"))+"원"; } }
        public int lb_AP_COUNT { get { return int.Parse(lb_ap_count.Text); } set { lb_ap_count.Text = value.ToString()+" 명"; } }
        public string lb_COM_TEL { get { return lb_com_tel.Text; } set { lb_com_tel.Text = value; } }
        public string lb_COM_ADDR { get { return lb_com_addr.Text; } set { lb_com_addr.Text = value; } }

        
    }
}
