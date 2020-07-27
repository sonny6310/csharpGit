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
using Login.PostRecruit;
using Login.Company.PostRecruit;

namespace Login.PostRecruit
{
      public partial class checkForm : Form
      {

            // DB연결
            string strConn = DBConnection.strconn;



            public checkForm()
            {
                  InitializeComponent();

            }

           
            private void insertData()
            {
                  SqlConnection sqlconn = new SqlConnection(strConn);
                  try
                  {
                        sqlconn.Open();
                        string cmdText = "Insert Into RECRUIT (W_NUM,ID,NAME,SUBJECT,COM_NAME,FIELD, PAY, W_START_TIME, W_END_TIME, W_PLACE," +
                              "W_DATE, PERIOD, W_CONTENT) VALUES(NEXT VALUE FOR W_NUMBER,@id,@name,@sbj,@com_name,@field,@pay,@start,@finish,@w_place,@time,@dead,@w_content)";
                        SqlCommand cmd = new SqlCommand(cmdText, sqlconn);

                        int intPay = Convert.ToInt32(Menu1.getPay());

                        cmd.Parameters.AddWithValue("@id", MainForm.getID());
                        cmd.Parameters.AddWithValue("@name", MainForm.getName());
                        cmd.Parameters.AddWithValue("@sbj", Menu1.getSbj());
                        cmd.Parameters.AddWithValue("@com_name", MainForm.getCom_name());
                        cmd.Parameters.AddWithValue("@field", Menu1.getField());
                        cmd.Parameters.AddWithValue("@pay", (intPay * 10000));
                        cmd.Parameters.AddWithValue("@start", Menu1.getStart());
                        cmd.Parameters.AddWithValue("@finish", Menu1.getFinish());
                        cmd.Parameters.AddWithValue("@w_place", Menu1.getPlace());
                        cmd.Parameters.AddWithValue("@time", DateTime.Now);
                        cmd.Parameters.AddWithValue("@dead", Menu1.getDead());
                        cmd.Parameters.AddWithValue("@w_content", Menu1.getContent());

                        cmd.ExecuteNonQuery();


                        onYesExit();


                  }
                  catch (Exception ee)
                  {
                        Log.printLog("공고 등록 오류");
                        MessageBox.Show(ee.Message);
                        MessageBox.Show(ee.StackTrace);
                  }
                  finally
                  {
                        sqlconn.Close();

                  }


            }

            private void onApplyBtn(object sender, EventArgs e)
            {
                  try
                  {

                        
                        checkPost();

                  }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);

                  }

            }
            private void checkPost()
            {
                  while (true)
                  {

                        if (String.IsNullOrEmpty(Menu1.getSbj()) || String.IsNullOrWhiteSpace(Menu1.getSbj()) ||
                              String.IsNullOrEmpty(Menu1.getField()) || String.IsNullOrWhiteSpace(Menu1.getField()) ||
                                    String.IsNullOrEmpty(Menu1.getPay()) || String.IsNullOrWhiteSpace(Menu1.getPay()) ||
                                          String.IsNullOrEmpty(Menu1.getPlace()) || String.IsNullOrWhiteSpace(Menu1.getPlace()))
                        {
                              MessageBox.Show("텍스트 박스에 문자를 삽입하여 주세요");
                              break;
                        }
                        /*
                        if (Menu1.getStart().Date == Menu1.getFinish().Date || Menu1.getStart().Date == Menu1.getDead().Date)
                        {
                              MessageBox.Show("날짜를 입력하세요");
                              break;
                        }*/
                        else
                        {
                              insertData();
                              break;
                        }
                  }
            }

            private void onCancelBtn(object sender, EventArgs e)
            {
                  this.Close();
            }

            private void onYesExit()
            {
                  string str = "yes";
                  Close();

                  if (str == "yes")
                  {
                        Log.printLog("공고 등록 성공");
                        Menu2.getInstance().selectData();
                        Menu2.getInstance().BringToFront();

                  }
            }




      }
}
