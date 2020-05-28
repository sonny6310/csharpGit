using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomWithTimer
{
    public partial class Form1 : Form
    {
        private int number = 0; //정답
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(1, 11);
            Console.WriteLine(number);
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            //int input = int.Parse(textBox_input.Text);
            int input = 0;
            bool test = int.TryParse(textBox_input.Text, out input);
            if(test == false)
            {
                MessageBox.Show("잘못된 값입니다!");
            }
            else
            {
                if(input > number)
                {
                    MessageBox.Show("선택한 숫자가 더 큽니다.");
                }
                else if(input < number)
                {
                    MessageBox.Show("선택한 숫자가 더 작습니다.");
                }
                else
                {
                    time = 0;
                    timer1.Enabled = false;
                    MessageBox.Show("정답입니다!");
                    label_time.Text = "Finished!";
                    number = new Random().Next(1, 11);
                    Console.WriteLine(number);
                    timer1.Enabled = true;
                }
            }

        }

        private int time = 0; //초
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time > 5)
            {
                time = 0;
                timer1.Enabled = false;
                MessageBox.Show("TimeOver!");
                label_time.Text = "Time Over";
            }
            else
            {
                label_time.Text = time.ToString();
            }
        }
    }
}
