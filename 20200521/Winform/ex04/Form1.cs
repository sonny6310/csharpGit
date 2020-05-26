using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox_square.Text);
            // 인스턴스메소드 이용
            label_square.Text = new TestClass().Power(num).ToString();

            // TestClass 내의 메서드/변수들 static으로 선언하고나서 ↓
            // 클래스메소드 이용
            //label_square.Text = TestClass.Power(num).ToString();
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox_multi1.Text);
            int num2 = int.Parse(textBox_multi2.Text);
            // 인스턴스메소드 이용
            label_multi.Text = new TestClass().Multi(num1, num2).ToString();

            // TestClass 내의 메서드/변수들 static으로 선언하고나서 ↓
            // 클래스메소드 이용
            //label_multi.Text = TestClass.Multi(num1, num2).ToString();
        }
    }
}
