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
using QRCoder;

namespace KIOSK_v1
{
    public partial class uc1_bookedPrint : UserControl
    {

        #region 클래스
        public uc1_bookedPrint()
        {
            InitializeComponent();
            ButtonEvent();

            roundbar = 0;
            barnum = 0;
            hcash = 0;

            rcash = "";
            scash = "";
            ccash = "";
            mcash = "";
            dcash = "";
            tcash = "";
            pcash = "";
            title = "";
            rating = "";
            runtime = "";
            Ticketid = "";
        }

        static uc1_bookedPrint bookedPrintObj;        // uc1_bookedPrint 의 객체 선언
        public static uc1_bookedPrint bookedPrintInst // BookedPrintObj 의 인스턴스
        {
            get
            {
                if (bookedPrintObj == null)
                {
                    bookedPrintObj = new uc1_bookedPrint();
                }
                return bookedPrintObj;
            }
            set { bookedPrintObj = value; }
        }
        #endregion

        #region 변수
        public string rcash { get; set; }
        public string scash { get; set; }
        public string ccash { get; set; }
        public string mcash { get; set; }
        public string dcash { get; set; }
        public string tcash { get; set; }
        public string pcash { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string runtime { get; set; }
        public static string Ticketid { get; set; }

        public int hcash { get; set; }
        public static int roundbar { get; set; }
        public static int barnum { get; set; }
        

        private string res = string.Empty;
        
        public Panel BookedTicket
        {
            get { return bookedTicket; }
            set { bookedTicket = value; }
        }
        #endregion

        #region 함수

        // 숫자 클릭
        private void ButtonEvent()
        {
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button6.Click += Button_Click;
            button5.Click += Button_Click;
            button4.Click += Button_Click;
            button9.Click += Button_Click;
            button8.Click += Button_Click;
            button7.Click += Button_Click;
            button0.Click += Button_Click;

        }

        // 초과 입력 시
        public void Button_Click(object sender, EventArgs e)
        {
            if (bookedPrintInst.input.Text.Length == 13)
            {
                MessageBox.Show("11자리 이상 입력하실 수 없습니다.");
                return;
            }
            // 12345 -> 123-4
            // op[0] = 1, op[1] = 2,  op[2] = 3,  op[3] = 4, op[4] = 5
            // op[3] = "-" 
            // op[4] 길이가 없어... 

            res += ((Button)sender).Tag;
            bookedPrintInst.input.Text = res;

            char[] op = bookedPrintInst.input.Text.ToCharArray();
            char[] opr = new char[13];

            for (int i = 0; i < op.Length; i++)
            {
                opr[i] = op[i];
            }
            if (op.Length > 3 && op[3] != '-')
            {
                char temp = op[3];
                opr[3] = '-';
                opr[4] = temp;
            }
            if (op.Length > 8 && op[8] != '-')
            {
                char temp = op[8];
                opr[8] = '-';
                opr[9] = temp;
            }

            bookedPrintInst.input.Text = new string(opr);
            //string[] opStr = res.Split(op);
            //res += opStr.ToString();
            //MainForm.tic.input = ((Button)sender).Tag;
        }

        // 수정 클릭
        private void del_Click(object sender, EventArgs e)
        {
            if (bookedPrintInst.input.Text.Length > 0)
            {

                string cash = bookedPrintInst.input.Text.ToString().Remove(bookedPrintInst.input.Text.Length - 1);

                if (cash.Length > 0)
                {

                    if (cash[cash.Length - 1] == '-')
                    {
                        cash = cash.Remove(cash.Length - 1);
                    }

                    bookedPrintInst.input.Text = cash;
                    res = bookedPrintInst.input.Text;
                }

                else
                {
                    bookedPrintInst.input.Text = "";
                    res = bookedPrintInst.input.Text;
                }
            }
            //char[]temp = input.Text.ToCharArray();
            //temp
        }

        // 조회
        private void enter_Click(object sender, EventArgs e)
        {
            if (bookedPrintInst.input.Text.Length != 13)
            {
                MessageBox.Show("잘못된 번호 입니다.");
                return;
            }
            
            if (Ticketid == bookedPrintInst.input.Text.Replace("-", ""))
            {
                return;
            }

            else
            {
                bookedPrintInst.BookedTicket.Controls.Remove(uc1_catalog.prepaidBar.prepaidBarInst);
                uc1_catalog.prepaidBar.prepaidBarInst = null;
            }



                Ticketid = bookedPrintInst.input.Text.Replace("-", "");
                Console.WriteLine("조회할 번호 : " + Ticketid);
                try
                {
                    Main.conn.Open();
                    string sql1 = "SELECT * FROM InfoTicket WHERE ticketID = '" + Ticketid + "';";
                    SqlCommand cmd1 = new SqlCommand(sql1, Main.conn);
                    cmd1.ExecuteNonQuery();

                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt1);

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        bookedPrintInst.rcash = dr1["roundID"].ToString();
                        bookedPrintInst.scash = dr1["selected"].ToString();
                        bookedPrintInst.ccash = dr1["chkPoint"].ToString();
                        bookedPrintInst.pcash = dr1["printed"].ToString();
                    }

                    // 출력된 티켓 검증 
                    //if(pcash == "Y")
                    //{
                    //    MessageBox.Show("이미 출력된 티켓입니다.");
                    //    return;
                    //}

                    string sql2 = "SELECT * FROM InfoRunde WHERE roundID = '" + bookedPrintInst.rcash + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, Main.conn);
                    cmd2.ExecuteNonQuery();

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);

                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        bookedPrintInst.mcash = dr2["mcode"].ToString();

                        bookedPrintInst.dcash = dr2["date"].ToString();

                        string h = dr2["hallNum"].ToString();
                        bookedPrintInst.hcash = Convert.ToInt32(h);

                        uc1_catalog.prepaidBar.prepaidBarInst = new uc1_catalog.prepaidBar();
                        bookedPrintInst.tcash = dr2["time"].ToString();

                        string sql3 = "SELECT * FROM InfoFilm WHERE mcode = '" + bookedPrintInst.mcash + "';";
                        SqlCommand cmd3 = new SqlCommand(sql3, Main.conn);
                        cmd3.ExecuteNonQuery();

                        DataTable dt3 = new DataTable();
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                        da3.Fill(dt3);

                        foreach (DataRow dr3 in dt3.Rows)
                        {
                            bookedPrintInst.title = dr3["title"].ToString();
                            bookedPrintInst.rating = dr3["rating"].ToString();
                            bookedPrintInst.runtime = dr3["runTime"].ToString();
                        }
                        uc1_catalog.prepaidBar.prepaidBarInst.fillBar(); // 바타입 입력                                                       
                        Console.WriteLine(++roundbar + "번 바 : " + bookedPrintInst.title + " / " + bookedPrintInst.mcash + " - 사전예매");
                    
                    }
                    if (String.IsNullOrEmpty(title))
                    {
                        MessageBox.Show("없는 번호 입니다.");
                        Main.conn.Close();
                        return;
                    }
                    Console.WriteLine("\n바 타입 입력 완료 - 사전예매");
                    Main.conn.Close();
                    return;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("티켓 조회실패 입력 실패 : " + ex.Message);
                    MessageBox.Show("없는 번호 입니다.");
                    return;
                }
                finally
                {
                    Main.conn.Close();
                }
        }

        // 출력하기
        private void printThis_Click(object sender, EventArgs e)
        {
            if (uc1_bookedPrint.bookedPrintInst.movieTitle.Text != uc1_catalog.prepaidBar.prepaidBarInst.BarTitle.Text)
            {
                MessageBox.Show("티켓을 선택해 주십시오.");
                return;
            }
            try
            {
                Main.conn.Open();
                string sql = "UPDATE InfoTicket SET printed = 'Y' WHERE ticketID = '" + Ticketid + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("\n출력 및 인쇄여부 기록 성공");

                Main.conn.Close();
                Main.mainInst.MainPanel.Controls.Add(uc6_complete.completeInst);
                uc6_complete.completeInst.BringToFront();

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(Ticketid, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                uc6_complete.completeInst.QRCodeImage.Image = code.GetGraphic(4);

                uc6_complete.completeInst.movieTitle.Text = bookedPrintInst.title;
                uc6_complete.completeInst.roundTime.Text = bookedPrintInst.rcash;
                uc6_complete.completeInst.hall.Text = bookedPrintInst.hcash.ToString();
                uc6_complete.completeInst.seat.Text = bookedPrintInst.scash;
                uc6_complete.completeInst.chkPoint.Text = bookedPrintInst.seat.Tag.ToString();

                Main.mainInst.BottomPanel.SendToBack();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("출력 및 인쇄여부 기록 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        #endregion
    }
}
