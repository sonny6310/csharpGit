using Login.Individual.JobRecruitment;
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

namespace Login.Individual.CompanyInfo
{
      public partial class ApplyCompany : Form
      {
            string strconn = DBConnection.strconn;
            PostInfo pi = new PostInfo();

            public ApplyCompany()
            {
                  InitializeComponent();
            }

            
            public string applysbj { get { return apply_subject.Text; } set { apply_subject.Text = value; } }
            public string apply_com_name { get { return Apply_Com_Name.Text; } set { Apply_Com_Name.Text = value; } }
            public string applyfield { get { return apply_field.Text; } set { apply_field.Text = value; } }
            public int applypay { get { return int.Parse(apply_pay.Text); } set { apply_pay.Text = string.Format("{0}", value.ToString("#,##0")) + " 원"; } }
            public string applyplace { get { return apply_place.Text; } set { apply_place.Text = value; } }
            public string applystart { get { return apply_start.Text; } set { apply_start.Text = value; } }
            public string applyfinish { get { return apply_finish.Text; } set { apply_finish.Text = value; } }
            public string applydead { get { return apply_dead.Text; } set { apply_dead.Text = value; } }
            public string applycontent { get { return Content_Text.Text; } set { Content_Text.Text = value; } }
            public int applycount { get { return int.Parse(apply_count.Text); } set { apply_count.Text = string.Format("{0}", value.ToString("#,##0")) + "회"; } }
            public int applyacount { get { return int.Parse(apply_acount.Text); } set { apply_acount.Text = string.Format("{0}", value.ToString("#,##0")) + "명"; } }
           

            private void ApplyCompany_Load(object sender, EventArgs e)
            {
                  
                        SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {
                        
                        sqlcon.Open();
                        string cmdText = "select * from RECRUIT where W_NUM = @w_num";
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
           
                                    applysbj = DR["SUBJECT"].ToString();
                                    apply_com_name = DR["COM_NAME"].ToString();
                                    applyfield = DR["FIELD"].ToString();
                                    int paid;
                                    int.TryParse(DR["PAY"].ToString(), out paid);
                                    applypay = paid;
                                    applyplace = DR["W_PLACE"].ToString();
                                    applystart = DR["W_START_TIME"].ToString();
                                    applyfinish = DR["W_END_TIME"].ToString();
                                    applydead = DR["PERIOD"].ToString();
                                    applycontent = DR["W_CONTENT"].ToString();
                                    int count;
                                    int acount;
                                    int.TryParse(DR["COUNT"].ToString(), out count);
                                    applycount = count;
                                    int.TryParse(DR["A_COUNT"].ToString(), out acount);
                                    applyacount = acount;

                              }
                        }
                
                DR.Close();
                //해당 공고의 조회수 증가
                cmd.CommandText = "update RECRUIT set COUNT = (select COUNT from RECRUIT where W_NUM = @w_num3)+1 where W_NUM = @w_num4";
                cmd.Parameters.AddWithValue("@w_num3", PostInfo.getWnum());
                cmd.Parameters.AddWithValue("@w_num4", PostInfo.getWnum());
                cmd.ExecuteNonQuery();

            }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);
                        MessageBox.Show(ee.StackTrace);

                  }
                  finally
                  {
                        sqlcon.Close();
       
                  }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  checkApply ca = new checkApply();
                  ca.Show();
            }
      }
}
