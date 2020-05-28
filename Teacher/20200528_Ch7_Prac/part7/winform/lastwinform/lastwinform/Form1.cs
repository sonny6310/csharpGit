using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastwinform
{
    enum MyEnum
    {
        Banana, Apple, Grape
    }
    public partial class Form1 : Form
    {
        class CustomeForm:Form
        {
            public CustomeForm()
            {
                Text = "글자";
                Visible = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CustomeForm form = new CustomeForm();
            form.Show();
            //form.ShowDialog();

            string[] example = new string[3] {"바나나", "사과","포도" };

            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            MessageBox.Show(example[0]);
            MessageBox.Show(example[(int)MyEnum.Banana]);

            MessageBox.Show(((int)MyEnum.Banana).ToString());
            MessageBox.Show((MyEnum.Banana).ToString());

            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }
    }
}
