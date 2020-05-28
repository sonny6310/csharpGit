using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qz1
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int r = random.Next(1, 101);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            int a;
            int.TryParse(textBox1.Text, out a);
            if (a > r)
            {
                label_result.Text = $"{a}보다 작습니다.";
                label_reset.Text = "";
            }
            else if (a < r)
            {
                label_result.Text = $"{a}보다 큽니다.";
                label_reset.Text = "";
            }
            else
            {
                label_result.Text = "맞추셨습니다!";
                elapsdTime = 20;
                timer1.Enabled = false;
                r = new Random().Next(1, 101);
                label_reset.Text = "숫자가 바꼈습니다.";
            }
        }
        private int elapsdTime = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsdTime--;
            label_time.Text = elapsdTime + "초";
            if (elapsdTime == 0)
            {
                elapsdTime = 20;
                timer1.Enabled = false;
                MessageBox.Show("Game Over!!");
                label_result.Text = "시간 초과!!";
                r = new Random().Next(1, 101);
                label_reset.Text = "숫자가 바꼈습니다. 다시 맞춰주세요";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제한시간은 20초입니다");
            label_result.Text = "숫자를 입력하세요";
            label_reset.Text = "";
        }
    }
}
