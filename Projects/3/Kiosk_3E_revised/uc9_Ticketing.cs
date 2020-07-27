using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_2E
{
    public partial class uc9_Ticketing : UserControl
    {
        private string res = string.Empty;

        public uc9_Ticketing()
        {
            InitializeComponent();
            ButtonEvent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            MainForm.goHome_Click(sender, e);
            this.SendToBack();
            this.input.Text = "";
            res = string.Empty;
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            MainForm.goHome_Click(sender, e);
            this.SendToBack();
            this.input.Text = "";
            res = string.Empty;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            if(input.Text.Length == 8)
            {
                MessageBox.Show("7자리 이상 입력하실 수 없습니다.");
                return;
            }
            // 12345 -> 123-4
            // op[0] = 1, op[1] = 2,  op[2] = 3,  op[3] = 4, op[4] = 5
            // op[3] = "-" 
            // op[4] 길이가 없어... 

            res += ((Button)sender).Tag;
            input.Text = res;

            char[] op = input.Text.ToCharArray();
            char[] opr = new char[8];

            for (int i = 0; i < op.Length; i++)
            {
                opr[i] = op[i];
            }

            if (op.Length > 3 && op[3]!='-')
            {
                char temp = op[3];
                opr[3] = '-';
                opr[4] = temp;
            }

            input.Text = new string(opr);
            
            //string[] opStr = res.Split(op);
            //res += opStr.ToString();
            //MainForm.tic.input = ((Button)sender).Tag;
            
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.ToString().Remove(input.Text.Length - 1);
                res = input.Text;
            }
            //char[]temp = input.Text.ToCharArray();
            //temp
        }

        private void ButtonEvent()
        {
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            button11.Click += Button_Click;

        }

        private void enter_Click(object sender, EventArgs e)
        {
            MainForm.cpl.Show();

            MainForm.Instance.pnlContainer.Controls.Add(MainForm.cpl);
            MainForm.Instance.pnlContainer.Controls["uc8_Complete"].BringToFront();

            this.input.Text = "";
            res = string.Empty;
        }
    }
}
