using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment
{
    public partial class Form2_insert : Form
    {
        public Form2_insert()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            selectQuery();
        }

        // 로그
        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            LogWriter.PrintLog(logContents);
            listBox1.Items.Insert(0, logContents);
        }

        private string loginConn = "Data Source=munggu.iptime.org,11113;Initial Catalog=jh_20200611;Persist Security Info=True;User Id=sa;Password=8765432!";

        private void selectQuery()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(loginConn);
                sqlcon.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from resident;", sqlcon);
                adpt.Fill(ds);

                listView1.Items.Clear();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string pet = ((r["pets"]).Equals(true)) ? "Y" : "N";
                    string baby = ((r["baby"]).Equals(true)) ? "Y" : "N";
                    string[] data = { r["building"] + "", r["unit"] + "", r["head"] + "", r["member"] + "", r["contact"] + "", r["car1"] + "", r["car2"] + "", pet, baby, r["register"] + "", r["remark"] + "", r["reg_date"] + "" };
                    listView1.Items.Add(new ListViewItem(data));
                }

                sqlcon.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(loginConn);
                sqlcon.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("select head,member,contact,pets,baby,register from resident where building=@building and unit=@unit;", sqlcon);
                SqlParameter prmt1 = new SqlParameter();
                SqlParameter prmt2 = new SqlParameter();
                prmt1.ParameterName = "@building";
                prmt1.Value = Convert.ToInt32(tb_building.Text);
                prmt2.ParameterName = "@unit";
                prmt2.Value = Convert.ToInt32(tb_unit.Text);
                adpt.SelectCommand.Parameters.Add(prmt1);
                adpt.SelectCommand.Parameters.Add(prmt2);
                adpt.Fill(ds);


                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    // Null과 DBNull차이 확실히해야. MSSQL에서 보면 NULL이라 적혀서, c#에서 item["head"].Equals(null) 혹은 == null 등으로 비교하면 false라고 나옴.
                    if (!(item["head"].ToString() == string.Empty && item["member"].ToString() == string.Empty && item["contact"].ToString() == string.Empty && item["register"].ToString() == string.Empty))
                    {
                        MessageBox.Show("이미 등록되어있습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tb_head.Text == "" || tb_member.Text == "" || tb_contact.Text == "" || tb_pet.Text == "" || tb_baby.Text == "")
                        {
                            MessageBox.Show("기본 데이터가 입력되지 않았습니다.");
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("update resident set head = @head, member = @member, contact = @contact, car1 = @car1, car2 = @car2, pets = @pets, baby = @baby, remark = @remark, reg_date = getdate(), register = getdate() where building = @building and unit = @unit;", sqlcon);
                            cmd.Parameters.AddWithValue("@building", Convert.ToInt32(tb_building.Text));
                            cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(tb_unit.Text));
                            cmd.Parameters.AddWithValue("@head", tb_head.Text);
                            cmd.Parameters.AddWithValue("@member", Convert.ToInt32(tb_member.Text));
                            cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                            cmd.Parameters.AddWithValue("@car1", tb_car1.Text);
                            cmd.Parameters.AddWithValue("@car2", tb_car2.Text);

                            bool petBit = (Convert.ToInt32(tb_pet.Text) == 0) ? false : true;
                            bool babyBit = (Convert.ToInt32(tb_baby.Text) == 0) ? false : true;
                            cmd.Parameters.AddWithValue("@pets", petBit);
                            cmd.Parameters.AddWithValue("@baby", babyBit);
                            cmd.Parameters.AddWithValue("@remark", "전입");
                            cmd.ExecuteNonQuery();

                            string pet = (petBit.Equals(true)) ? "Y" : "N";
                            string baby = (babyBit.Equals(true)) ? "Y" : "N";
                            WriteLog($"[등록(전입)] {tb_building.Text}동 {tb_unit.Text}호    세대주 명:{tb_head.Text}    구성원 수:{tb_member.Text}    연락처:{tb_contact.Text}    차 번호1:{tb_car1.Text}    차 번호2:{tb_car2.Text}    애완동물:{pet}    영유아:{baby}");
                        }
                    }
                }
                sqlcon.Close();

                selectQuery();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(loginConn);
                sqlcon.Open();

                if (tb_head.Text == "" || tb_member.Text == "" || tb_contact.Text == "" || tb_pet.Text == "" || tb_baby.Text == "")
                {
                    MessageBox.Show("기본 데이터가 입력되지 않았습니다.");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update resident set head = @head, member = @member, contact = @contact, car1 = @car1, car2 = @car2, pets = @pets, baby = @baby, remark = @remark, reg_date = getdate() where building = @building and unit = @unit;", sqlcon);
                    cmd.Parameters.AddWithValue("@building", Convert.ToInt32(tb_building.Text));
                    cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(tb_unit.Text));
                    cmd.Parameters.AddWithValue("@head", tb_head.Text);
                    cmd.Parameters.AddWithValue("@member", Convert.ToInt32(tb_member.Text));
                    cmd.Parameters.AddWithValue("@contact", tb_contact.Text);
                    cmd.Parameters.AddWithValue("@car1", tb_car1.Text);
                    cmd.Parameters.AddWithValue("@car2", tb_car2.Text);

                    bool petBit = (Convert.ToInt32(tb_pet.Text) == 0) ? false : true;
                    bool babyBit = (Convert.ToInt32(tb_baby.Text) == 0) ? false : true;
                    cmd.Parameters.AddWithValue("@pets", petBit);
                    cmd.Parameters.AddWithValue("@baby", babyBit);
                    cmd.Parameters.AddWithValue("@remark", tb_remark.Text);
                    cmd.ExecuteNonQuery();

                    string pet = (petBit.Equals(true)) ? "Y" : "N";
                    string baby = (babyBit.Equals(true)) ? "Y" : "N";
                    WriteLog($"[수정({tb_remark.Text})] {tb_building.Text}동 {tb_unit.Text}호    세대주 명:{tb_head.Text}    구성원 수:{tb_member.Text}    연락처:{tb_contact.Text}    차 번호1:{tb_car1.Text}    차 번호2:{tb_car2.Text}    애완동물:{pet}    영유아:{baby}");
                }
                sqlcon.Close();

                selectQuery();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(loginConn);
                sqlcon.Open();

                DialogResult result = MessageBox.Show($"정말로 {tb_building.Text}동 {tb_unit.Text}호의 데이터를 지우시겠습니까?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from resident where building = @building and unit = @unit", sqlcon);
                    cmd.Parameters.AddWithValue("@building", Convert.ToInt32(tb_building.Text));
                    cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(tb_unit.Text));
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("insert into resident (building,unit,remark,reg_date) values (@building,@unit,@remark,getdate());", sqlcon);
                    cmd.Parameters.AddWithValue("@building", Convert.ToInt32(tb_building.Text));
                    cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(tb_unit.Text));
                    cmd.Parameters.AddWithValue("@remark", "전출");
                    cmd.ExecuteNonQuery();

                    WriteLog($"[삭제(전출)] {tb_building.Text}동 {tb_unit.Text}호");
                }
                sqlcon.Close();

                selectQuery();
            }
            catch (Exception except)
            {
                MessageBox.Show("\t\t-- 오류메시지 --\n" + except.Message + Environment.NewLine + Environment.NewLine + "\t\t-- 오류내용 --\n" + except.StackTrace, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_building.Text = listView1.FocusedItem.SubItems[0].Text;
                tb_unit.Text = listView1.FocusedItem.SubItems[1].Text;
                tb_head.Text = listView1.FocusedItem.SubItems[2].Text;
                tb_member.Text = listView1.FocusedItem.SubItems[3].Text;
                tb_contact.Text = listView1.FocusedItem.SubItems[4].Text;
                tb_car1.Text = listView1.FocusedItem.SubItems[5].Text;
                tb_car2.Text = listView1.FocusedItem.SubItems[6].Text;
                tb_pet.Text = (listView1.FocusedItem.SubItems[7].Text.Equals("N")) ? "0" : "1";
                tb_baby.Text = (listView1.FocusedItem.SubItems[8].Text.Equals("N")) ? "0" : "1";
            }
            catch (Exception except)
            {
            }
        }

        // textbox에 숫자, 백스페이스만 입력되게
        private void tb_onlyNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // 연락처textBox에 숫자, 백스페이스, -만 입력되게
        private void tb_numHyp(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }
      
        // listview column 클릭시 정렬
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == System.Windows.Forms.SortOrder.Ascending)
            {
                listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            listView1.ListViewItemSorter = new Sorter();      // * 1
            Sorter s = (Sorter)listView1.ListViewItemSorter;
            s.Order = listView1.Sorting;
            s.Column = e.Column;
            listView1.Sort();
        }
    }

}
