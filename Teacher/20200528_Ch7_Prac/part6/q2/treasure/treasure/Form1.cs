using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treasure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int limitTime = 0;
        int answer = 0;
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer = 0;
            label_result.Text = "Game Start!";
            answer = new Random().Next(1, 26);
            Console.WriteLine("answer : " + answer);
            int count = 1; //순차적으로 text 써줌\
            for(int i = 0; i <5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    Point point = new Point();
                    point.X = 13 + 100 * j;
                    point.Y = 13 + 13 + (23 + 3) * i;
                    button.Location = point;
                    button.Click += Button_Click;
                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button);


                }
            }

            timer1.Enabled = true;
            if(int.TryParse(textBox_limitTime.Text, out limitTime))
            {
                timer = -1;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == answer.ToString())
            {
                label_result.Text = "보물을 찾으셨습니다!";
                timer = 0;
                label_time.Text = timer.ToString();
                timer1.Enabled = false;
            }
            else
            {
                label_result.Text = "보물 아님!";
            }
            //throw new NotImplementedException();
        }

        private int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label_time.Text = timer.ToString();
            if(timer > limitTime || timer == -1)
            {
                label_result.Text = "Game Over!!!";
                timer = 0;
                label_time.Text = timer.ToString();
                timer1.Enabled = false;
            }


        }
    }
}
