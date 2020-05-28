using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05
{
    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true; // 자기자신을 Mdi컨테이너로 만듦.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.MdiParent = this; // MdiParent속성으로 부모를 자기자신으로 지정.
            form.Show();
        }
    }
}
