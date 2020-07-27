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

    public partial class Resume_LocationForm : Form
    {
        //폼간 연동
        public delegate void subFormSendEvent(string msg);
        public event subFormSendEvent onSubFormSendEvent;

        public Resume_LocationForm()
        {
            InitializeComponent();        
        }

        public Resume_LocationForm(string data)
        {
            InitializeComponent();
            //체크드리스트박스에 텍스를 데이터로 담기.
            checkedListBox1.Text = data;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)   {       }
        //변수에 선택된항목 담기
        private void getItems(string str)
        {
            string s = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                s = s + (i + 1).ToString() + checkedListBox1.CheckedItems[i].ToString();
            }
        }
        //체크된 항목(변수에담긴) 텍스트박스에 담기
        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tb_location.Text = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString();
        }
        //종료 및 데이터 imenu 희망 지역 텍스트박스에 보내기
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string s = tb_location.Text;
            onSubFormSendEvent(s);

            Close();
        }
    }
}
