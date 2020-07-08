using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public delegate void Del(string msg);
        public static event Del delEvent;

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(40, 50);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delEvent(textBox1.Text);
        }
    }
}
