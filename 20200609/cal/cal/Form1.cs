using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string output1 = "";
        private string output2 = "";
        private string op = "";
        private double result = 0;
        private void onNumb(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    output1 = output1 + ((Button)sender).Text;
                    output2 = output2 + ((Button)sender).Text;
                    textBox2.Text = output1;
                    break;
            }
        }

        private void onOp(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "+":
                case "-":
                case "×":
                case "÷":
                    if(op == "")
                    {
                        result = Convert.ToDouble(output1);
                    }
                    else if (op == "+")
                    {
                        result = result + Convert.ToDouble(output1);
                    }
                    else if (op == "-")
                    {
                        result = result - Convert.ToDouble(output1);
                    }
                    else if (op == "×")
                    {
                        result = result * Convert.ToDouble(output1);
                    }
                    else
                    {
                        result = result / Convert.ToDouble(output1);
                    }
                    output2 = output2 + "  " + ((Button)sender).Text + "  ";
                    textBox1.Text = output2;
                    textBox2.Text = result.ToString();
                    output1 = "";
                    op = ((Button)sender).Text;
                    break;
            }
        }

        private void onClear(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "0";
            output1 = "";
            output2 = "";
            result = 0;
        }

        private void onEqual(object sender, EventArgs e)
        {
            textBox1.Text = output2 + "  " + ((Button)sender).Text;
            if (op == "+")
            {
                result = result + Convert.ToDouble(output1);
            }
            else if (op == "-")
            {
                result = result - Convert.ToDouble(output1);
            }
            else if (op == "×")
            {
                result = result * Convert.ToDouble(output1);
            }
            else
            {
                result = result / Convert.ToDouble(output1);
            }
            textBox2.Text = result.ToString();
            output1 = "" + result;
            output2 = "" + result;
            op = "";
        }
    }
}
