using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
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

        string strconn = "Data Source=192.168.0.200;Initial Catalog=jh_20200611;";
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            DialogResult result = MessageBox.Show("DB연결을 하시겠습니까?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CustomForm form = new CustomForm();
                form.MdiParent = this; // MdiParent속성으로 부모를 자기자신으로 지정.
                form.Show();

            }
        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void select_click(object sender, EventArgs e)
        {

        }

        private void insert_click(object sender, EventArgs e)
        {

        }

        private void update_click(object sender, EventArgs e)
        {

        }

        private void delete_click(object sender, EventArgs e)
        {

        }
    }
}
