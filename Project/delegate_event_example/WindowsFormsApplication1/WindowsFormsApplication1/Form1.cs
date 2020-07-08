using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private delegate void Del(int a, int b);

        class A
        {
            public void print(int num1, int num2)
            {
                int sum = num1 + num2;
                Console.WriteLine(sum);
            }
        }

        public Form1()
        {
            InitializeComponent();

            A clA = new A();
            Del del = clA.print;

            Console.WriteLine("clA.print");
            clA.print(3,5);

            Console.WriteLine("del");
            del(3,5);
        }
    }
}
