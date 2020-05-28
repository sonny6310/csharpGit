using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            // 모달리스 form창 생성 (새로운 화면이 열려도 기존에 있던 화면 조작 가능)
            form.Show();

            // 모달 form창 생성 (새로운 화면을 띄웠을 때 기존 화면 조작 불가능)
            form.ShowDialog();
        }
    }
}
