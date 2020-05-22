using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qz4
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int r = rand.Next(1, 101);

        public Form1()
        {
            InitializeComponent();
            label_result.Text = "숫자를 입력하세요";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a > r)
            {
                label_result.Text = $"{a}보다 작습니다.";
                label_reset.Text = "";
            }else if (a < r)
            {
                label_result.Text = $"{a}보다 큽니다.";
                label_reset.Text = "";
            }else
            {
                label_result.Text = "맞추셨습니다!";
                r = new Random().Next(1, 101);
                label_reset.Text = "숫자가 바꼈습니다.";
            }
        }
    }
}
