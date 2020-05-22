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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        int answer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer = 0;
            answer = new Random().Next(1, 31);
            int count = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(13 + 100 * j, 13 + 13 + (23 + 3) * i);

                    // 생성된 button을 Click 하면 Button_Click 메서드가 실행된다.
                    button.Click += Button_Click;

                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button);
                }
            }
            timer1.Enabled = true;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == answer.ToString())
            {
                timer = 0;
                timer1.Enabled = false;
                label_result.Text = "보물발견!";
                MessageBox.Show("You Win!!!");
            }else
            {
                label_result.Text = "꽝이지롱~";
            }
        }
        private int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label_time.Text = timer.ToString() + "초";

            int limitTime;
            // textBox1.Text를 int형으로 변환을 시도하여 가능하면 그 값을 limitTime에 반환
            // 불가능하면 0을 limitTime에 반환
            int.TryParse(textBox1.Text, out limitTime);

            if (limitTime == timer || limitTime == 0)
            {
                timer = 0;
                timer1.Enabled = false;
                MessageBox.Show("Game Over!!!");
            }
        }
    }
}
