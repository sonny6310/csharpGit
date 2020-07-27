using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcrommV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadMainForm();
        }
        //마우스 클릭 이동 (상단바)
        private Point mousePoint; //마우스 클릭 이동 변수
        private void topP_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void topP_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }

        //app 종료
        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadMainForm()
        {
            MainForm.getInstance().TopLevel = false;
            MainForm.getInstance().TopMost = true;
            MainForm.getInstance().Dock = DockStyle.Fill;
            mainP.Controls.Add(MainForm.getInstance());
            MainForm.getInstance().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
