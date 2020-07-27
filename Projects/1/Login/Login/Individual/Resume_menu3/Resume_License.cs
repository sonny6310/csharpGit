using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Resume_License : Form
    {
        //폼간 연동
        public delegate void subFormSendEvent(string msg);
        public event subFormSendEvent onSubFormSendEvent;

        public Resume_License()
        {
            InitializeComponent();
        }
        public Resume_License(string data)
        {
            InitializeComponent();
            //체크드리스트박스에 텍스를 데이터로 담기.
            checkedListBox2.Text = data;
        }
        //변수에 선택된항목 담기
        private void getItems(string str)
        {
            string l = "";
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                l = l + (i + 1).ToString() + checkedListBox2.CheckedItems[i].ToString();
            }

        }
        //체크된 항목(변수에담긴) 텍스트박스에 담기
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_License.Text = checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString();
        }

        //종료 및 데이터 imenu 자격증 텍스트박스에 보내기
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string l = tb_License.Text;
            onSubFormSendEvent(l);
            //tb_License.Text = checkedListBox2.Items[checkedListBox2.SelectedIndex].ToString();
            Close();
        }

    }
}
