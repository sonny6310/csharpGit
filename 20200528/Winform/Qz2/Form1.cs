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
            IsMdiContainer = true;
            

            DialogResult result = MessageBox.Show("윈도우 사용자입니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //CustomForm form = new CustomForm();
                //form.MdiParent = this; // MdiParent속성으로 부모를 자기자신으로 지정.
                //form.Show();
                
                Part5_1 part5_1 = new Part5_1();
                part5_1.MdiParent = this;
                part5_1.StartPosition = FormStartPosition.Manual;
                part5_1.Location = new Point(200, 0);
                part5_1.Show();
                Part5_2 part5_2 = new Part5_2();
                part5_2.MdiParent = this;
                part5_2.StartPosition = FormStartPosition.Manual;
                part5_2.Location = new Point(40, 300);
                part5_2.Show();
            }
            else
            {
                Part6_1 part6_1 = new Part6_1();
                part6_1.MdiParent = this;
                part6_1.StartPosition = FormStartPosition.Manual;
                part6_1.Location = new Point(50, 0);
                part6_1.Show();
                Part6_2 part6_2 = new Part6_2();
                part6_2.MdiParent = this;
                part6_2.StartPosition = FormStartPosition.Manual;
                part6_2.Location = new Point(350, 0);
                part6_2.Show();
                Part6_3 part6_3 = new Part6_3();
                part6_3.MdiParent = this;
                part6_3.StartPosition = FormStartPosition.Manual;
                part6_3.Location = new Point(70, 300);
                part6_3.Show();
            }
        }
    }
}
