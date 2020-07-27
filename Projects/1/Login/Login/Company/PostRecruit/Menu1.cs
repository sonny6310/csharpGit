using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login.PostRecruit;
using Login.Company.PostRecruit;

namespace Login
{
      public partial class Menu1 : UserControl
      {
            static PostInsert pi = new PostInsert();
         

            private bool firstClick = false;
          

            public Menu1()
            {
                  InitializeComponent();
            }


            public static string getSbj()
            {
                  return pi.text_Subject;
            }
            public static string getField()
            {
                  return pi.text_Field;
            }
            public static string getPlace()
            {
                  return pi.text_Place;
            }

            public static string getPay()
            {
                  return pi.text_Pay;
            }
            public static string getContent()
            {
                  return pi.text_Content;
            }
            public static DateTime getStart()
            {
                  return pi.date_TimeStart;
            }
            public static DateTime getFinish()
            {
                  return pi.date_TimeFinish;
            }
            public static DateTime getDead()
            {
                  return pi.dead_LineTime;
            }


      



            private void applyBtn_Click(object sender, EventArgs e)
            {
                  pi.text_Subject = textSubject.Text;
                  pi.text_Field = textField.Text;
                  pi.text_Place = textPlace.Text;
                  pi.text_Pay = textPay.Text;
                  pi.text_Content = textContent.Text;
                  pi.date_TimeStart = dateTimeStart.Value;
                  pi.date_TimeFinish = dateTimeFinish.Value;
                  pi.dead_LineTime = deadLineTime.Value;

                  onCallcheckForm(sender, e);


            }

            private void textContent_Click(object sender, EventArgs e)
            {

                  if (firstClick == false)
                  {
                        firstClick = true;
                        textContent.Text = "";
                  }
                  textContent.ForeColor = System.Drawing.Color.Black;
            }
            private void onCallcheckForm(object sender, EventArgs e)
            {
                  checkForm checkform = new checkForm();
                  checkform.StartPosition = FormStartPosition.Manual;
                  checkform.Location = new Point(580, 350);
                  checkform.Show();

            }
            private void dateTimeStart_CloseUp(object sender, EventArgs e)
            {
                  if (dateTimeStart.Value.Year < DateTime.Now.Year && dateTimeStart.Value.Month < DateTime.Now.Month && dateTimeStart.Value.Day < DateTime.Now.Day)
                  {
                        MessageBox.Show("현재 날짜보다 전의 날짜로는 설정할 수 없습니다");
                        dateTimeStart.Value = DateTime.Now;
                  }

            }

            private void dateTimeFinish_CloseUp(object sender, EventArgs e)
            {
                  if (dateTimeStart.Value > dateTimeFinish.Value)
                  {
                        MessageBox.Show("종료시기는 시작시기보다 뒤로 설정하여 주십시오");
                        dateTimeFinish.Value = DateTime.Now;
                  }
            }

            private void deadLineTime_CloseUp(object sender, EventArgs e)
            {
                  if (deadLineTime.Value > dateTimeFinish.Value || deadLineTime.Value < dateTimeStart.Value)
                  {
                        MessageBox.Show("접수 마감 날짜는 작업시작시기와 종료시기에 맞추어 설정하여 주세요");
                        deadLineTime.Value = DateTime.Now;
                  }
            }

           

            private void applyBtn_Leave(object sender, EventArgs e)
            {
                  textSubject.Text = "";
                  textField.Text = "";
                  textPlace.Text = "";
                  textPay.Text = "";
                  dateTimeStart.Value = DateTime.Now;
                  dateTimeFinish.Value = DateTime.Now;
                  deadLineTime.Value = DateTime.Now;
                  firstClick = false;
                  textContent.Text = "구인내용에는 우대사항과 작업내용을 등을 기입하여 주시기 바랍니다";
                  textContent.ForeColor = System.Drawing.Color.Gray;
                  
            }
      }
}
