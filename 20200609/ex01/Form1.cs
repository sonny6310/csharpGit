using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Height = 50; 

        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onInfo(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 계산 수행 앱","간단 계산기",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x;
            double.TryParse(textBox1.Text.ToString(), out x);

            double y;
            double.TryParse(textBox2.Text.ToString(), out y);

            double result = x + y;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x;
            double.TryParse(textBox1.Text.ToString(), out x);

            double y;
            double.TryParse(textBox2.Text.ToString(), out y);

            double result = x - y;
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x;
            double.TryParse(textBox1.Text.ToString(), out x);

            double y;
            double.TryParse(textBox2.Text.ToString(), out y);

            double result = x * y;
            textBox3.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x;
            double.TryParse(textBox1.Text.ToString(), out x);

            double y;
            double.TryParse(textBox2.Text.ToString(), out y);

            double result = x / y;
            textBox3.Text = result.ToString("0.00");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "0";
        }
    }
}
