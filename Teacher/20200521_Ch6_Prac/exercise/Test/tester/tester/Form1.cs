using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //case 1
            new TestClass().Print();
            
            //case 2(recommanded)
            TestClass t = new TestClass();
            t.Print();
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            int square = int.Parse(textBox_square.Text);
            TestClass test = new TestClass();
            int result = test.Power(square);
            label_sResult.Text = result.ToString();
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            int mul1 = int.Parse(textBox_mul1.Text);
            int mul2 = int.Parse(textBox_mul2.Text);
            TestClass test = new TestClass();
            int result = test.Multi(mul1, mul2);
            label_mResult.Text = result.ToString();
        }
    }
}
