using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(Test(10).ToString());
            MessageBox.Show(Test(10.5).ToString());
            MessageBox.Show(Test(10,14).ToString());
        }

        // 오버로딩
        public int Test(int input)
        {
            return 0;
        }
        public int Test(double input)
        {
            return 1;
        }
        public int Test(int input, int input2)
        {
            return 2;
        }
    }
}
