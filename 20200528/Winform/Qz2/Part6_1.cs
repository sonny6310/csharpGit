using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qz2
{
    public partial class Part6_1 : Form
    {
        public Part6_1()
        {
            InitializeComponent();
            label_result.Text = " ";
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            double wd;
            double ht;
            double.TryParse(textBox_width.Text, out wd);
            double.TryParse(textBox_height.Text, out ht);
            Box box = new Box(wd,ht);
            label_result.Text = box.Area().ToString("0.00");
        }
    }
}
