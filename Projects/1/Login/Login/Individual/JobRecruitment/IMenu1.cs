using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Login.Individual.JobRecruitment;
using System.Data.SqlClient;

namespace Login
{
      public partial class IMenu1 : UserControl
      {
            PostInfo pi = new PostInfo();
            string strconn = DBConnection.strconn;
            private int count;
            private int refreshCount;
            private string search_keyword;

            public IMenu1()
            {
                  InitializeComponent();
            }
            //컨트롤 둥글게 만들기 위해 참조
            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

            [DllImport("user32.dll")]
            private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);


            private void postView(DataSet ds)
            {
                  flowLayoutPanel.Controls.Clear();
                  PostInfo[] postinfo = new PostInfo[count];
                  int i = 0;

                  foreach (DataRow item in ds.Tables[0].Rows)
                  {
                        postinfo[i] = new PostInfo();
                        int wnumber;
                        int.TryParse(item["W_NUM"].ToString(), out wnumber);
                        postinfo[i].write_num = wnumber;
                        postinfo[i].Com_Name = item["COM_NAME"].ToString();
                        postinfo[i].Info_Field = item["FIELD"].ToString();
                        int paid;
                        int.TryParse(item["PAY"].ToString(), out paid);
                        postinfo[i].Info_Pay = paid;
                        postinfo[i].Info_Place = item["W_PLACE"].ToString();
                        if (flowLayoutPanel.Controls.Count < 0)
                        {
                              flowLayoutPanel.Controls.Clear();
                        }

                        postinfo[i].Info_Start = item["W_START_TIME"].ToString();
                        postinfo[i].Info_Finish = item["W_END_TIME"].ToString();
                        postinfo[i].Info_Dead = item["PERIOD"].ToString();

                        flowLayoutPanel.Controls.Add(postinfo[i]);
                        i++;

                  }
            }
            private void IMenu1_Load(object sender, EventArgs e)
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {

                        DataSet ds = new DataSet();
                        sqlcon.Open();
                        string cmdText = "select * from RECRUIT";
                        //                     string cmdText2 = "select CONVERT(CHAR(10), PERIOD, 23) AS PERIOD FROM RECRUIT  ";
                        SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                        adpt.Fill(ds);
                        count = ds.Tables[0].Rows.Count;
                        postView(ds);
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


                  IntPtr tbRound = CreateRoundRectRgn(0, 0, panelSearch.Width, panelSearch.Height, 10, 10);
                  int i = SetWindowRgn(panelSearch.Handle, tbRound, true);
            }

            private bool firstClick = false;

            private void textSearch_MouseClick(object sender, MouseEventArgs e)
            {
                  if (firstClick == false)
                  {

                        textSearch.Text = "";
                        firstClick = true;
                  }
            }
            private void selectData()
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {
                        DataSet ds = new DataSet();
                        sqlcon.Open();
                        string cmdText = "SELECT * FROM RECRUIT WHERE SUBJECT LIKE '%' + @search_keyword + '%' OR COM_NAME LIKE '%' + @search_keyword + '%' ORDER BY SUBJECT ASC, COM_NAME DESC;";
                        SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                        cmd.Parameters.AddWithValue("@search_keyword", "null");
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(ds);
                        count = ds.Tables[0].Rows.Count;
                        postView(ds);

                  }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.StackTrace);
                        MessageBox.Show(ee.Message);

                  }
                  finally
                  {
                        sqlcon.Close();
                  }


            }

            private void selectData(string str)
            {
                  if (str.Equals(""))
                  {
                        selectData();
                  }
                  else
                  {

                        SqlConnection sqlcon = new SqlConnection(strconn);
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();
                              string cmdText = "SELECT * FROM RECRUIT WHERE SUBJECT LIKE '%' + @search_keyword + '%' OR COM_NAME LIKE '%' + @search_keyword + '%' ORDER BY SUBJECT ASC, COM_NAME DESC;";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              cmd.Parameters.AddWithValue("@search_keyword", str);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);

                        }
                        catch (Exception ee)
                        {
                              MessageBox.Show(ee.StackTrace);
                              MessageBox.Show(ee.Message);

                        }
                        finally
                        {
                              sqlcon.Close();
                        }


                  }
            }

            //refresh버튼
            private void refreshBtn_Click(object sender, EventArgs e)
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {

                        DataSet ds = new DataSet();
                        sqlcon.Open();
                        string cmdText = "select * from RECRUIT order by W_NUM desc";

                        SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                        adpt.Fill(ds);
                        count = ds.Tables[0].Rows.Count;
                        postView(ds);
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
            //최신순
            private void recent_search_btn_Click(object sender, EventArgs e)
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  if (refreshCount % 2 == 0)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();

                              string cmdText = "select * from RECRUIT order by W_NUM desc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);


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
                  if (refreshCount % 2 == 1)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();

                              string cmdText = "select * from RECRUIT order by W_NUM asc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);



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
                  refreshCount++;
            }
            //급여순


            private void pay_search_btn_Click(object sender, EventArgs e)
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  if (refreshCount % 2 == 0)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();


                              string cmdText = "select * from RECRUIT order by PAY desc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);



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
                  if (refreshCount % 2 == 1)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();

                              string cmdText = "select * from RECRUIT order by PAY asc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);



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
                  refreshCount++;

            }
            //조회순
            private void count_search_btn_Click(object sender, EventArgs e)
            {
                  SqlConnection sqlcon = new SqlConnection(strconn);
                  if (refreshCount % 2 == 0)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();


                              string cmdText = "select * from RECRUIT order by COUNT desc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);



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
                  if (refreshCount % 2 == 1)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();

                              string cmdText = "select * from RECRUIT order by COUNT asc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);



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
                  refreshCount++;
            }
            //지원자순      
            private void apply_search_btn_Click(object sender, EventArgs e)
            {

                  SqlConnection sqlcon = new SqlConnection(strconn);
                  if (refreshCount % 2 == 0)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();


                              string cmdText = "select * from RECRUIT order by A_COUNT desc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);

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
                  if (refreshCount % 2 == 1)
                  {
                        try
                        {
                              DataSet ds = new DataSet();
                              sqlcon.Open();

                              string cmdText = "select * from RECRUIT order by A_COUNT asc";
                              SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                              SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                              adpt.Fill(ds);
                              count = ds.Tables[0].Rows.Count;
                              postView(ds);


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
                  refreshCount++;

            }

            private void btnOk_Click(object sender, EventArgs e)
            {
                  search_keyword = textSearch.Text;
                  selectData(search_keyword);
            }

            private void textSearch_KeyDown(object sender, KeyEventArgs e)
            {
                  if (e.KeyCode == Keys.Enter)
                  {
                        this.btnOk_Click(sender, e);
                  }
            }
      }
}
