using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment
{
    public partial class Form2_cal : Form
    {
        public Form2_cal()
        {
            InitializeComponent();
        }

        private bool dateClick = false;
        private string dt1;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DateTime dt = dateTimePicker1.Value;
            dt1 = dt.ToString("yyyy/MM/dd");

            IEnumerable<string> log = System.IO.File.ReadLines(@"D:\2020csharp\20200617\Winform\Crud\bin\Debug\LogFolder\Log.txt");
            foreach (string logLine in log)
            {
                if (logLine.Contains(dt1))
                {
                    listBox1.Items.Insert(0, logLine);
                    listBox1.Items.Insert(0, Environment.NewLine);
                }
            }
            dateClick = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<string> log = System.IO.File.ReadLines(@"D:\2020csharp\20200617\Winform\Crud\bin\Debug\LogFolder\Log.txt");
            foreach (string logLine in log)
            {
                if (dateClick)
                {
                    if (logLine.Contains(textBox1.Text) && logLine.Contains(dt1))
                    {
                        listBox1.Items.Insert(0, logLine);
                        listBox1.Items.Insert(0, Environment.NewLine);
                    }
                }
                else
                {
                    if (logLine.Contains(textBox1.Text))
                    {
                        listBox1.Items.Insert(0, logLine);
                        listBox1.Items.Insert(0, Environment.NewLine);
                    }
                }
            }

            dateClick = false;
        }
    }
}
