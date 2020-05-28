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
    public partial class Part6_2 : Form
    {
        public List<string> list = new List<string>();

        public Part6_2()
        {
            InitializeComponent();

            list.Add("안녕");
            list.Add("뭐해?");
            list.Add("잘가");

            button1.Text = "클릭";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelText.Text = "";
            int i = new Random().Next(list.Count);
            labelText.Text += list[i];
        }
    }
}
