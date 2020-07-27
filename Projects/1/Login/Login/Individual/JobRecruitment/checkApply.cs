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

namespace Login.Individual.JobRecruitment
{
    public partial class checkApply : Form
    {
        string strconn = DBConnection.strconn;

        private bool checkOver = false;

        public checkApply()
        {
            InitializeComponent();
        }

        private void insertData()
        {
            SqlConnection sqlconn = new SqlConnection(strconn);
            try
            {
                sqlconn.Open();
                string cmdText = "Insert into A_LIST (A_NUM, W_NUM, A_ID, A_NAME, A_PHONE, A_ADDR, A_COM_NAME," +
                      "A_COM_FIELD, A_COM_PAY, A_COM_PLACE) VALUES(NEXT VALUE FOR A_NUMBER, @w_num, @a_id, @a_name, @a_phone, @a_addr, @a_com_name, @a_com_field, @a_com_pay, @a_com_place)";
                SqlCommand cmd = new SqlCommand(cmdText, sqlconn);

                cmd.Parameters.AddWithValue("@w_num", PostInfo.getWnum());
                cmd.Parameters.AddWithValue("@a_id", IMemberMainForm.getID());
                cmd.Parameters.AddWithValue("@a_name", IMemberMainForm.getName());
                cmd.Parameters.AddWithValue("@a_phone", IMemberMainForm.getPhone());
                cmd.Parameters.AddWithValue("@a_addr", IMemberMainForm.getAddr());
                cmd.Parameters.AddWithValue("@a_com_name", PostInfo.getCname());
                cmd.Parameters.AddWithValue("@a_com_field", PostInfo.getCfield());
                cmd.Parameters.AddWithValue("@a_com_pay", PostInfo.getCpay());
                cmd.Parameters.AddWithValue("@a_com_place", PostInfo.getCplace());
                checkOverlap();
                if (checkOver == true)
                {
                    MessageBox.Show("중복 지원할 수 없습니다");
                    this.Close();
                }
                else
                {
                    cmd.ExecuteNonQuery();

                    //해당 공고의 지원자 수 증가
                    cmd.CommandText = "Update RECRUIT set A_COUNT = (select A_COUNT from RECRUIT where W_NUM = @w_num1)+1 where W_NUM = @w_num2";
                    cmd.Parameters.AddWithValue("@w_num1", PostInfo.getWnum());
                    cmd.Parameters.AddWithValue("@w_num2", PostInfo.getWnum());
                    cmd.ExecuteNonQuery();

                    //회사 정보 폼의 회사 지원수 증가
                    cmd.CommandText = "select * from COM_INFO where COM_NAME = @com_name";
                    cmd.Parameters.AddWithValue("@com_name", PostInfo.getCname());
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        int a_count = int.Parse(dr["AP_COUNT"].ToString());
                        cmd.CommandText = "update COM_INFO set AP_COUNT = @a_count where COM_NAME = @com_name1";
                        cmd.Parameters.AddWithValue("@a_count", a_count+1);
                        cmd.Parameters.AddWithValue("@com_name1", PostInfo.getCname());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("지원이 완료되었습니다!");
                    Log.printLog($"{PostInfo.getWnum()}번글 지원 완료");
                }

            }
            catch (Exception ee)
            {
                Log.printLog("지원 실패");
                MessageBox.Show(ee.StackTrace);
                MessageBox.Show(ee.Message);

            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void checkOverlap()
            {

                  SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {

                        sqlcon.Open();
                        string cmdText = "select * from A_LIST where W_NUM = @w_num";
                        SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                        cmd.CommandText = cmdText;
                        cmd.Parameters.AddWithValue("@w_num", PostInfo.getWnum());
                        DataSet ds = new DataSet();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(ds);
                        SqlDataReader DR = cmd.ExecuteReader();

                        if (DR.HasRows)
                        {
                              while (DR.Read())
                              {

                                    if (DR["A_ID"].ToString() == IMemberMainForm.getID())
                                    {
                                          checkOver = true;
                                          this.Close();
                                    }

                              }
                        }
                        DR.Close();

                  }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);
                        MessageBox.Show(ee.StackTrace);

                  }

            }


            private void Apply_Ok_btn_Click(object sender, EventArgs e)
            {
                  try
                  {
                        
                        insertData();

                  }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);

                  }
                  finally
                  {
                        this.Close();

                  }
            }

            private void Apply_Cancel_btn_Click(object sender, EventArgs e)
            {
                  this.Close();
            }
      }
}
