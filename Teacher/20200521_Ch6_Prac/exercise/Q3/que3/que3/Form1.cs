using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace que3
{
    public partial class Form1 : Form
    {
        //가위 = 0, 바위 = 1, 보 = 2
        public Form1()
        {
            InitializeComponent();
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            int myChoice = 0;
            int computerChoice = new Random().Next(0, 3); //0, 1, 2 

            label_me.Text = "가위";
            switch (computerChoice)
            {
                case 0:
                    label_computer.Text = "가위";
                    label_result.Text = "비김";
                    break;
                case 1:
                    label_computer.Text = "바위";
                    label_result.Text = "패배";
                    break;
                case 2:
                    label_computer.Text = "보";
                    label_result.Text = "이김";
                    break;
                default:
                    break;
            }
        }

        private void button_r_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int computerChoice = new Random().Next(0, 3); //0, 1, 2 

            label_me.Text = button_r.Text;
            switch (computerChoice)
            {
                case 0:
                    label_computer.Text = "가위";
                    label_result.Text = "이김";
                    break;
                case 1:
                    label_computer.Text = "바위";
                    label_result.Text = "비김";
                    break;
                case 2:
                    label_computer.Text = "보";
                    label_result.Text = "패배";
                    break;
                default:
                    break;
            }
        }

        private void button_p_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int computerChoice = new Random().Next(0, 3); //0, 1, 2 

            label_me.Text = button_p.Text;
            switch (computerChoice)
            {
                case 0:
                    label_computer.Text = "가위";
                    label_result.Text = "패배";
                    break;
                case 1:
                    label_computer.Text = "바위";
                    label_result.Text = "이김";
                    break;
                case 2:
                    label_computer.Text = "보";
                    label_result.Text = "비김";
                    break;
                default:
                    break;
            }
        }
    }
}
