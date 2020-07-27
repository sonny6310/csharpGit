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
    public partial class managerLogin : Form
    {
        adminLogin m_FormTest = new adminLogin();
        public managerLogin()
        {
            InitializeComponent();
            m_FormTest.ButtonClicked += new eventButtonClicked(Form1_ButtonClicked);
        }
        void Form1_ButtonClicked()
        {
            this.Close();
        }
        static managerLogin instance;
        public static managerLogin getinstance()
        {
            if (instance == null)
            {
                instance = new managerLogin();
            }
            return instance;
        }
        private void loginB_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text == "admin" && pwTextbox.Text == "1234")
            {

                m_FormTest.Show();
            }
            else
            {
                MessageBox.Show("없는 아이디 이거나 패스워드가 틀렸습니다");
            }
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pwTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginB_Click(sender, e);
            }
        }
    }
}
