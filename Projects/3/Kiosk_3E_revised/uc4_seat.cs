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

namespace KIOSK_v1
{
    public partial class uc4_seat : UserControl
    {
        #region 클래스
        static uc4_seat seatObj;        // uc4_seat 의 객체 선언
        public static uc4_seat seatInst // SeatObj 의 인스턴스 생성
        {
            get
            {
                if (seatObj == null)
                {
                    seatObj = new uc4_seat();
                }
                return seatObj;
            }
            set { seatObj = value; }
        }
        public uc4_seat()
        {
            InitializeComponent();
            seatObj = this;
            getBooked();
            hideSeat();
            uc5_addDis.addDisInst.Dis = "";
            uc5_addDis.addDisInst.Total = "";

            progressNow.Text = seatInst.Date + " / " + seatInst.Time + "\n" + seatInst.HallNum + "관 / " +
                seatInst.Title + "  예매중입니다.";
        }
        #endregion

        #region 변수
        static string title;   // 영화제목
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        static string mcode;   // 영화코드
        public string Mcode
        {
            get { return mcode; }
            set { mcode = value; }
        }

        static int hallNum;   // 상영관
        public int HallNum
        {
            get { return hallNum; }
            set { hallNum = value; }
        }

        static string date;   // 상영일자
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        static string time;   // 상영시간
        public string Time
        {
            get { return time; }
            set { time = value; }
        }


        static string ticketID;  // 티켓 ID
        public string TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        static string selected = "";    // 선택한 좌석
        public string Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        static string booked = ""; // 예약완료된 좌석
        public string Booked
        {
            get { return booked; }
            set { booked = value; }
        }

        static string chk;           // 해당자리
        public string Chk
        {
            get { return chk; }
            set { chk = value; }
        }

        static int ticket = 0;          // 선택 티켓 수
        public int Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }

        static int money = 0;   // 결제 원금
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        const int aPrice = 10000;    // 성인 요금
        const int yDis = -3000;    // 청소년 할인

        #endregion

        #region 함수

        //예매완료된 좌석 선택 방지
        public void hideSeat()  
        {
            if (booked.Contains("A1")) { stateA1.BringToFront(); }
            if (booked.Contains("A2")) { stateA2.BringToFront(); }
            if (booked.Contains("A3")) { stateA3.BringToFront(); }
            if (booked.Contains("A4")) { stateA4.BringToFront(); }
            if (booked.Contains("B1")) { stateB1.BringToFront(); }
            if (booked.Contains("B2")) { stateB2.BringToFront(); }
            if (booked.Contains("B3")) { stateB3.BringToFront(); }
            if (booked.Contains("B4")) { stateB4.BringToFront(); }
            if (booked.Contains("B5")) { stateB5.BringToFront(); }
            if (booked.Contains("C1")) { stateC1.BringToFront(); }
            if (booked.Contains("C2")) { stateC2.BringToFront(); }
            if (booked.Contains("C3")) { stateC3.BringToFront(); }
            if (booked.Contains("C4")) { stateC4.BringToFront(); }
            if (booked.Contains("C5")) { stateC5.BringToFront(); }
            if (booked.Contains("D3")) { stateD3.BringToFront(); }
            if (booked.Contains("D4")) { stateD4.BringToFront(); }
            if (booked.Contains("D5")) { stateD5.BringToFront(); }
        }

        //좌석 선택
        public void Select(Label lbl)  
        {
            if (uc3_roundPeople.roundPeopleInst.Person > 0)
            {
                if ((lbl != null) && (lbl.BackColor != Color.Purple))
                {
                    lbl.BackColor = (lbl.BackColor == SystemColors.ControlDark) ? Color.Purple : SystemColors.ControlDark;
                    if ((lbl.BackColor == Color.Purple) && (seatInst.Selected == ""))
                    {
                        seatInst.Selected += seatInst.Chk;
                        uc3_roundPeople.roundPeopleInst.Person--;
                        seatInst.Ticket++;
                    }
                    else if ((lbl.BackColor == Color.Purple) && (seatInst.Selected != ""))
                    {
                        seatInst.Selected += "," + seatInst.Chk;
                        uc3_roundPeople.roundPeopleInst.Person--;
                        seatInst.Ticket++;
                    }
                }
                else
                {
                    lbl.BackColor = SystemColors.ControlDark;
                    seatInst.Selected = seatInst.Selected.Replace(seatInst.Chk, "");
                    uc3_roundPeople.roundPeopleInst.Person++;
                    seatInst.Ticket--;
                }
            }
            else if ((uc3_roundPeople.roundPeopleInst.Person == 0) && (lbl.BackColor == Color.Purple))
            {
                lbl.BackColor = SystemColors.ControlDark;
                seatInst.Selected = seatInst.Selected.Replace(seatInst.Chk, "");
                uc3_roundPeople.roundPeopleInst.Person++;
                seatInst.Ticket--;
            }
            else
            {
                MessageBox.Show("좌석선택이 완료되었습니다.");
            }

            if (seatInst.Selected == "")
            {
                return;
            }
            else if (seatInst.Selected[0] == ',')
            {
                seatInst.Selected = seatInst.Selected.Substring(1);
            }

            else if (seatInst.Selected[(seatInst.Selected.Length) - 1] == ',')
            {
                seatInst.Selected = seatInst.Selected.Substring(0, seatInst.Selected.Length - 1);
            }

            else if (selected.Contains(",,"))
            {
                seatInst.Selected = seatInst.Selected.Replace(",,", ",");
            }

            Console.WriteLine("선택한 좌석 : " + seatInst.Selected);
            selectedSeats.Text = seatInst.Selected;

            Console.WriteLine("구매할 티켓 수 : " + uc3_roundPeople.roundPeopleInst.Person);
            seatInst.Money = seatInst.Ticket * aPrice;
            if (uc3_roundPeople.roundPeopleInst.Person == 0)
            {
                seatInst.Money += uc3_roundPeople.roundPeopleInst.Youth * yDis;
            }
            seatInst.sum.Text = seatInst.Money.ToString();
        }

        // 선택 "체크표시" 초기화
        public void seatUnchk()
        {
            if (A1.BackColor == Color.Purple) { A1.BackColor = SystemColors.ControlDark; };
            if (A2.BackColor == Color.Purple) { A2.BackColor = SystemColors.ControlDark; };
            if (A3.BackColor == Color.Purple) { A3.BackColor = SystemColors.ControlDark; };
            if (A4.BackColor == Color.Purple) { A4.BackColor = SystemColors.ControlDark; };
            if (B1.BackColor == Color.Purple) { B1.BackColor = SystemColors.ControlDark; };
            if (B2.BackColor == Color.Purple) { B2.BackColor = SystemColors.ControlDark; };
            if (B3.BackColor == Color.Purple) { B3.BackColor = SystemColors.ControlDark; };
            if (B4.BackColor == Color.Purple) { B4.BackColor = SystemColors.ControlDark; };
            if (B5.BackColor == Color.Purple) { B5.BackColor = SystemColors.ControlDark; };
            if (C1.BackColor == Color.Purple) { C1.BackColor = SystemColors.ControlDark; };
            if (C2.BackColor == Color.Purple) { C2.BackColor = SystemColors.ControlDark; };
            if (C3.BackColor == Color.Purple) { C3.BackColor = SystemColors.ControlDark; };
            if (C4.BackColor == Color.Purple) { C4.BackColor = SystemColors.ControlDark; };
            if (C5.BackColor == Color.Purple) { C5.BackColor = SystemColors.ControlDark; };
            if (D3.BackColor == Color.Purple) { D3.BackColor = SystemColors.ControlDark; };
            if (D4.BackColor == Color.Purple) { D4.BackColor = SystemColors.ControlDark; };
            if (D5.BackColor == Color.Purple) { D5.BackColor = SystemColors.ControlDark; };
        }
        
        // 선택 "좌석번호" 초기화
        public void ssReset()   
        {
            seatInst.Ticket = 0;
            seatInst.Money = 0;
            seatInst.Selected = "";
            seatInst.sum.Text = "";
            seatInst.selectedSeats.Text = "";
            seatInst.Selected = "";
        }

        // 선택 완전 초기화
        public void reset_Click(object sender, EventArgs e)
        {
            Console.WriteLine("선택좌석 : " + seatInst.Selected);

            uc3_roundPeople.roundPeopleInst.Person += seatInst.Ticket;
            Console.WriteLine("\n필요한 티켓 수 : " + uc3_roundPeople.roundPeopleInst.Person);
            Console.WriteLine("--------------------");

           ssReset();
            seatUnchk();
        }

        // 예약된 좌석 booked 및 선택 회차정보 추출
        public void getBooked()
        {
            try
            {
                Main.conn.Open();

                string sql = "SELECT * fROM InfoRunde WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";

                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    seatInst.Mcode = dr["mcode"].ToString();
                    seatInst.Date = dr["date"].ToString();
                    seatInst.Time = dr["time"].ToString();
                    string hall = dr["hallNum"].ToString();
                    seatInst.HallNum = Convert.ToInt32(hall);
                    booked = dr["booked"].ToString();
                }

                sql = "SELECT title FROM InfoFilm WHERE mcode = '" + seatInst.Mcode + "';";

                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                seatInst.Title = dt.Rows[0][0].ToString();

                Main.conn.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("판매완료된 좌석 추출 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }
        
        // 예약된 좌석 booked 에 선택한 좌석 selected 추가
        public void insertSelected(string insSel)
        {
            try
            {
                Main.conn.Open();
                string sql;
                if (String.IsNullOrEmpty(seatInst.Booked))
                {
                    sql = "UPDATE InfoRunde SET booked = '" + insSel + "' WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';" +
                           "SELECT booked fROM InfoRunde WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";
                }
                else
                {
                    sql = "UPDATE InfoRunde SET booked = '" + seatInst.Booked + "," + insSel + "' WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "' AND booked = '" + seatInst.Booked + "';" +
                            "SELECT booked fROM InfoRunde WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";
                }
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                seatInst.Booked = dt.Rows[0][0].ToString();
                Console.WriteLine("선택좌석 추가 성공");
                Console.WriteLine("선택좌석 : " + insSel);
                Console.WriteLine("마감좌석 : " + seatInst.Booked);
                
                Main.conn.Close();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("선택좌석 추가 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 티켓에서 selected 찾아서 booked 에서 삭제
        public void deleteSelected(string delSel)
        {
            try
            {
                Main.conn.Open();
                string sql = "SELECT booked FROM InfoRunde WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                seatInst.Booked = dt.Rows[0][0].ToString();
                
                if(seatInst.Booked == delSel)
                {
                    sql = "UPDATE InfoRunde SET booked ='' WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";

                }
                else
                {
                    sql = "UPDATE InfoRunde SET booked = '" + seatInst.Booked.Replace("," + delSel, "") + "' WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";
                }
                
                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();
                                
                sql = "SELECT booked FROM InfoRunde WHERE roundID = '" + uc2_movieRound.movieRoundInst.RoundID + "';";
                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                seatInst.Booked = dt.Rows[0][0].ToString();

                Console.WriteLine("선택좌석 제거 성공");
                Console.WriteLine("선택좌석 : " + delSel);
                Console.WriteLine("마감좌석 : " + seatInst.Booked);

                Main.conn.Close();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("선택좌석 제거 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }
        
        // ticketID 를 위한 11자리 난수 발생
        public string generateID()  
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 12; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        // 생성된 난수가 ticketID 로 적합한지 판별
        public bool idTest(string tID)
        {
            try
            {
                Main.conn.Open();
                string sql = "SELECT ticketID FROM InfoTicket;";

                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int i = 1;
                foreach(DataRow dr in dt.Rows)
                {
                    string testID = dr[0].ToString();
                    if(testID == tID)
                    {
                        Console.WriteLine("이미 존재하는 ticketID 입니다.");
                        Main.conn.Close();
                        return false;

                    }
                    Console.WriteLine("ticketID 중복검사 "+(i++)+"회 : "+ testID + " / " + tID);
                }
                Console.WriteLine(tID + "는 이용가능한 ticketID 입니다.");
                                

                Main.conn.Close();
                return true;
            }

            catch
            {

                Console.WriteLine("ticketID  중복검사 실패");
                return false;

            }
            finally
            {
                Main.conn.Close();
            }
            
        }

        // 티켓 생성 및 입력
        public void generateTicket()
        {
            do
            {
                ticketID = generateID();
            } while (idTest(ticketID) == false);

            try
            {
                Main.conn.Open();
                string sql = "INSERT INTO InfoTicket (ticketID, roundID, selected) VALUES('" + ticketID + "','" + uc2_movieRound.movieRoundInst.RoundID + "','"
                        + seatInst.Selected + "');";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n티켓 생성 성공");
                Main.conn.Close();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("티켓 생성 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 티켓 소멸
        public void terminateTicket()
        {
            deleteSelected(selected);
            try
            {
                Main.conn.Open();
                string sql = "DELETE FROM InfoTicket WHERE ticketID = '" + ticketID + "';";

                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n티켓 삭제 성공");
                Main.conn.Close();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("티켓 삭제 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 결제하기
        public void pay_Click(object sender, EventArgs e)
        {
            if (uc3_roundPeople.roundPeopleInst.Person != 0)    //인원수만큼 좌석선택을 하지 않으면 다음으로 넘어가지 않게
            {
                MessageBox.Show("좌석을 선택해주세요");
            }
            else
            {
                Console.WriteLine("");

                getBooked();
                string[] stdParts = seatInst.Selected.Split(',');
                
                for (int i = 0; i < stdParts.Length; i++)
                {
                    Console.WriteLine("최종좌석 검사 - 좌석 " + (i + 1) + " : "+ stdParts[i]); 
                    bool selectedExists = seatInst.Booked.Contains(stdParts[i]);
                    if (selectedExists == true)
                    {
                        MessageBox.Show("죄송합니다.\n판매좌석이 변동되었습니다.");
                        Console.WriteLine("");
                        reset_Click(sender, e);
                        getBooked();
                        hideSeat();
                        return;
                    }
                }
                Console.WriteLine("최종좌석 검사 - 이상 무\n");
                generateTicket();
                insertSelected(seatInst.Selected);

                uc5_payment.uc5w1_selectTel.sltInst.A = 0;
                    
                Main.mainInst.MainPanel.Controls.Add(uc5_addDis.addDisInst);
                uc5_addDis.addDisInst.BringToFront();
                uc5_addDis.addDisInst.fillDetail();
                uc5_addDis.addDisInst.Total = seatInst.sum.Text;    // 금액 uc5_addDis 로 넘기기
                uc5_addDis.addDisInst.Sum = seatInst.sum.Text;

                Main.mainInst.Page += 1;
            }
        }

        // 클릭시 좌석 선택 및 취소
        private void A1_Click(object sender, EventArgs e)
        {
            chk = "A1";
            Label lab = sender as Label;
            Select(lab);
        }
        private void A2_Click(object sender, EventArgs e)
        {
            chk = "A2";
            Label lab = sender as Label;
            Select(lab);
        }
        private void A3_Click(object sender, EventArgs e)
        {
            chk = "A3";
            Label lab = sender as Label;
            Select(lab);
        }
        private void A4_Click(object sender, EventArgs e)
        {
            chk = "A4";
            Label lab = sender as Label;
            Select(lab);
        }
        private void B1_Click(object sender, EventArgs e)
        {
            chk = "B1";
            Label lab = sender as Label;
            Select(lab);
        }
        private void B2_Click(object sender, EventArgs e)
        {
            chk = "B2";
            Label lab = sender as Label;
            Select(lab);
        }
        private void B3_Click(object sender, EventArgs e)
        {
            chk = "B3";
            Label lab = sender as Label;
            Select(lab);
        }
        private void B4_Click(object sender, EventArgs e)
        {
            chk = "B4";
            Label lab = sender as Label;
            Select(lab);
        }
        private void B5_Click(object sender, EventArgs e)
        {
            chk = "B5";
            Label lab = sender as Label;
            Select(lab);
        }
        private void C1_Click(object sender, EventArgs e)
        {
            chk = "C1";
            Label lab = sender as Label;
            Select(lab);
        }
        private void C2_Click(object sender, EventArgs e)
        {
            chk = "C2";
            Label lab = sender as Label;
            Select(lab);
        }
        private void C3_Click(object sender, EventArgs e)
        {
            chk = "C3";
            Label lab = sender as Label;
            Select(lab);
        }
        private void C4_Click(object sender, EventArgs e)
        {
            chk = "C4";
            Label lab = sender as Label;
            Select(lab);
        }
        private void C5_Click(object sender, EventArgs e)
        {
            chk = "C5";
            Label lab = sender as Label;
            Select(lab);
        }
        private void D3_Click(object sender, EventArgs e)
        {
            chk = "D3";
            Label lab = sender as Label;
            Select(lab);
        }
        private void D4_Click(object sender, EventArgs e)
        {
            chk = "D4";
            Label lab = sender as Label;
            Select(lab);
        }
        private void D5_Click(object sender, EventArgs e)
        {
            chk = "D5";
            Label lab = sender as Label;
            Select(lab);
        }

        #endregion
    }
}
