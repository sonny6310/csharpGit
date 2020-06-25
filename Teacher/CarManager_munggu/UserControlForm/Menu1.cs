using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlForm
{
    public partial class Menu1 : UserControl
    {
        SQLSeverManager ssm = SQLSeverManager.getInstance();
        string status = "";
        int selectRowIndex = -1;

        public Menu1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ssm.getDataSetBoard().Tables[0];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ssm.deleteBoard(dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString());
            dataGridView1.DataSource = ssm.getDataSetBoard().Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            status = "insert";
            btnEnableFalse();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            status = "update";
            btnEnableFalse();
        }

        private void btnEnableFalse()
        {
            txt_content.Enabled = true;
            txt_email.Enabled = true;
            txt_pw.Enabled = true;
            txt_subject.Enabled = true;
            txt_writer.Enabled = true;

            btn_delete.Enabled = false;
            btn_insert.Enabled = false;
            btn_update.Enabled = false;

            btn_ok.Enabled = true;
        }

        private void btnEnableTrue()
        {
            txt_content.Enabled = false;
            txt_email.Enabled = false;
            txt_pw.Enabled = false;
            txt_subject.Enabled = false;
            txt_writer.Enabled = false;

            btn_delete.Enabled = true;
            btn_insert.Enabled = true;
            btn_update.Enabled = true;

            btn_ok.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btnEnableTrue();
            if( status.Equals("insert"))
            {
                ssm.insertBoard();
                dataGridView1.DataSource = ssm.getDataSetBoard().Tables[0];
            }
            else if (status.Equals("update"))
            {
                ssm.updateBoard(dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString());
                dataGridView1.DataSource = ssm.getDataSetBoard().Tables[0];
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRowIndex = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
            txt_writer.Text = selectRow.Cells[1].Value.ToString();
            txt_email.Text = selectRow.Cells[2].Value.ToString();
            txt_subject.Text = selectRow.Cells[3].Value.ToString();
            txt_pw.Text = selectRow.Cells[4].Value.ToString();
            txt_content.Text = selectRow.Cells[10].Value.ToString();

        }
    }
}
