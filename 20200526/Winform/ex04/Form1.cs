using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double.TryParse(textBox1.Text, out a);
            double.TryParse(textBox2.Text, out b);
            Swap(ref a, ref b);
            textBox3.Text = a.ToString();
            textBox4.Text = b.ToString();
        }
        // ref : 레퍼런스
        private void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
