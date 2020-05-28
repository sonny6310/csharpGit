using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03
{
    enum MyEnum
    {
        Banana, Apple, Grape
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            MessageBox.Show(((int)MyEnum.Banana).ToString());
            MessageBox.Show((MyEnum.Banana).ToString());

            string[] example = new string[3] { "바나나", "사과", "포도" };
            MessageBox.Show(example[0]);

            MessageBox.Show(example[(int)MyEnum.Banana]);

            DialogResult result;
            do
            {
                result = MessageBox.Show("내용","제목",MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }
    }
}
