using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PC 초기화면 
namespace PcrommV2
{
    public delegate void eventButtonClicked();
    public partial class adminLogin : Form
    {
        public event eventButtonClicked ButtonClicked;
        public adminLogin()
        {
            InitializeComponent();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ButtonClicked();
        }

        private void enterB_Click(object sender, EventArgs e)
        {
            initConn();
            MessageBox.Show("입력완료\n프로그램을 다시 시작합니다");
            Application.Restart();
        }
        public void initConn()
        {
            LoginData login_data = new LoginData();
            login_data.WriteIni(pcnamTextbox.Text, serverAddTextbox.Text, serverNameTextbox.Text, serverIDTextbox.Text, serverPwTextbox.Text);
        }
    }
}
