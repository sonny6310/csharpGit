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

            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string compNum = new Random().Next(3).ToString();
            labelText.Text = "";
            labelText2.Text = "";
            if (compNum == "0")
            {
                labelText2.Text = "가위";
                labelText.Text += "비겼습니다.";
            }
            else if(compNum == "1")
            {
                labelText2.Text = "바위";
                labelText.Text += "졌습니다.";
            }
            else
            {
                labelText2.Text = "보";
                labelText.Text += "이겼습니다!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string compNum = new Random().Next(3).ToString();
            labelText.Text = "";
            if (compNum == "0")
            {
                labelText2.Text = "가위";
                labelText.Text += "이겼습니다!";
            }
            else if (compNum == "1")
            {
                labelText2.Text = "바위";
                labelText.Text += "비겼습니다.";
            }
            else
            {
                labelText2.Text = "보";
                labelText.Text += "졌습니다.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string compNum = new Random().Next(3).ToString();
            labelText.Text = "";
            if (compNum == "0")
            {
                labelText2.Text = "가위";
                labelText.Text += "졌습니다.";
            }
            else if (compNum == "1")
            {
                labelText2.Text = "바위";
                labelText.Text += "이겼습니다!";
            }
            else
            {
                labelText2.Text = "보";
                labelText.Text += "비겼습니다.";
            }
        }
    }
}
