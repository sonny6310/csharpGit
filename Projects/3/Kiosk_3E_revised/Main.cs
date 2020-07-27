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



namespace KIOSK_v1
{

    public partial class Main : Form
    {

        #region 클래스
        public Main()
        {
            InitializeComponent();

            mainObj = this;
            Console.WriteLine("프로그램 시작");
            Console.WriteLine("=============");
            syncDB();
            uc1_movieList.movieListInst.fillMovie();
            timer1.Start();
            timer2.Start();
            timer1.Interval = 1000;
            timer2.Interval = 1000;

            today.Parent = homeCover;
            today.BringToFront();
            branch.Parent = homeCover;
            branch.BringToFront();
            nowTime.Parent = homeCover;
            nowTime.BringToFront();
        }
        static Main mainObj;           // MainForm 의 객체 선언
        public static Main mainInst // MainObj 의 인스턴스 생성
        {
            get
            {
                if (mainObj == null)
                {
                    mainObj = new Main();
                }
                return mainObj;
            }
            set
            {
                mainObj = value;
            }
        }
        #endregion

        #region 변수
        public static SqlConnection conn = new SqlConnection("Data Source=munggu.iptime.org,25000;Initial Catalog=KinoDB;Persist Security Info=True;User ID=sa;Password=8765432!");
        // SQL 연결 정보

        public static string tempID;    // 검사를 위한 임시 ID
        public static string tempBooked;    // 검사를 위한 임시 예약완료 좌석
        public static string delSel;    // 삭제하려는 자리
        public static string tempRound; // 임시 회차 ID

        private Point mousePoint;   // 마우스 위치
        
        static int page = 0; // 페이지수 선언 및 접근 허용
        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        public Panel MainPanel  // mainPanel 접근 허용
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }

        public Panel BottomPanel  // bottomPanel 접근 허용
        {
            get { return bottomPanel; }
            set { bottomPanel = value; }
        }

        public Panel HomePanel  // HomePanel 접근 허용
        {
            get { return homePanel; }
            set { homePanel = value; }
        }

        public PictureBox TurnBack
        {
            get { return turnBack; }
            set { turnBack = value; }
        }

        public PictureBox GoHome
        {
            get { return goHome; }
            set { goHome = value; }
        }
        #endregion

        #region 함수

        #region DB 관련
        
        // 미결제 티켓 조회하여 삭제
        private void syncDB()
        {
            try
            {
                Console.WriteLine("미결제 티켓 조회");
                Main.conn.Open();
                string sql = "SELECT * FROM InfoTicket WHERE payment is null";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tempID = row["ticketID"].ToString();
                    delSel = row["selected"].ToString();
                    tempRound = row["roundID"].ToString();
                    Main.conn.Close();
                    terminateTicket();
                    i++;
                    Main.conn.Open();
                }

                Console.WriteLine("미결제 티켓 " + i + "장 파기");
                Console.WriteLine("-----------------------");
                Main.conn.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("미결제 티켓 소멸 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 미결제 티켓으로 예약한 좌석 삭제
        public static void deleteSelected(string delSel)
        {
            try
            {
                Main.conn.Open();
                string sql = "SELECT booked FROM InfoRunde WHERE roundID = '" + tempRound + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tempBooked = dt.Rows[0][0].ToString();

                if (tempBooked == delSel)
                {
                    sql = "UPDATE InfoRunde SET booked ='' WHERE roundID = '" + tempRound + "';";
                }
                else
                {
                    sql = "UPDATE InfoRunde SET booked = '" + tempBooked.Replace("," + delSel, "") + "' WHERE roundID = '" + tempRound + "';";
                }
                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                sql = "SELECT booked FROM InfoRunde WHERE roundID = '" + tempRound + "';";
                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                tempBooked = dt.Rows[0][0].ToString();

                Console.WriteLine("\n선택좌석 제거 성공");
                Console.WriteLine("선택좌석 : " + delSel);
                Console.WriteLine("마감좌석 : " + tempBooked);

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

        // 티켓 삭제
        public static void terminateTicket()
        {
            deleteSelected(delSel);
            try
            {

                Main.conn.Open();
                string sql = "DELETE FROM InfoTicket WHERE ticketID = '" + tempID + "';";

                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("티켓 삭제 성공");
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
        
        #endregion

        #region 창 위치 및 크기 변환 
        
        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값 지정
        private void Main_Down(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        private void Home_Down(object sender, MouseEventArgs e)
        {
            Main_Down(sender, e);
        }
        // 클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값 차감
        private void Main_Move(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        private void Home_Move(object sender, MouseEventArgs e)
        {
            Main_Move(sender, e);
        }
        // 더블클릭시 최대, 최소화
        private void Main_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            mainPanel.Location = new Point(this.Width / 2 - mainPanel.Size.Width / 2, this.Height / 2 - mainPanel.Size.Height / 2);
            homePanel.Location = new Point(this.Width / 2 - homePanel.Size.Width / 2, this.Height / 2 - homePanel.Size.Height / 2);
        }
        private void Home_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            mainInst.turnBack.Visible = false;
            mainInst.turnBack.Enabled = false;
            mainInst.goHome.Visible = false;
            mainInst.goHome.Enabled = false;
            mainPanel.Location = new Point(this.Width / 2 - mainPanel.Size.Width / 2, this.Height / 2 - mainPanel.Size.Height / 2);
            homePanel.Location = new Point(this.Width / 2 - homePanel.Size.Width / 2, this.Height / 2 - homePanel.Size.Height / 2);
            
        }

        // 날짜 및 시간
        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            today.Text = DateTime.Now.ToLongDateString();
        }
        
        // 예매 티켓 출력
        private void bookedPrint_Click(object sender, EventArgs e)
        {
            mainInst.turnBack.Visible = true;
            mainInst.turnBack.Enabled = true;
            mainInst.goHome.Visible = true;
            mainInst.goHome.Enabled = true;
            mainInst.homePanel.SendToBack();
            mainInst.bottomPanel.BringToFront();

            mainInst.MainPanel.Controls.Add(uc1_bookedPrint.bookedPrintInst);
            uc1_bookedPrint.bookedPrintInst.BringToFront();

            mainInst.Page += 1;
        }
        // 예매 티켓 출력 버튼 효과
        private void bookedPrint_Hover(object sender, EventArgs e)
        {
            mainInst.bookedPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void bookedPrint_Leave(object sender, EventArgs e)
        {
            mainInst.bookedPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        // 티켓 구매
        private void buyTicket_Click(object sender, EventArgs e)
        {
            mainInst.turnBack.Visible = true;
            mainInst.turnBack.Enabled = true;
            mainInst.goHome.Visible = true;
            mainInst.goHome.Enabled = true;
            mainInst.homePanel.SendToBack();
            mainInst.BottomPanel.BringToFront();

            mainInst.MainPanel.Controls.Add(uc1_movieList.movieListInst);
            uc1_movieList.movieListInst.BringToFront();

            mainInst.Page += 1;
        }
        // 티켓 구매 버튼 효과
        private void buyTicket_Hover(object sender, EventArgs e)
        {
            mainInst.buyTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void buyTicket_Leave(object sender, EventArgs e)
        {
            mainInst.buyTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        
        #endregion

        #region 화면 간 이동
        
        // 이전화면
        public void turnBack_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case 1: // 영화 선택 movieList -> 처음 homePanel
                    mainInst.homePanel.BringToFront();
                    mainInst.MainPanel.Controls.Remove(uc1_bookedPrint.bookedPrintInst);
                    uc1_bookedPrint.bookedPrintInst = null;
                    uc1_catalog.prepaidBar.prepaidBarInst = null;
                    mainInst.Page -= 1;
                    break;

                case 2: // 상영회차 선택 movieRound -> 영화 선택 movieList
                    mainInst.MainPanel.Controls.Remove(uc2_movieRound.movieRoundInst);
                    if (uc2_movieRound.movieRoundInst != null)
                    {
                        uc2_movieRound.movieRoundInst = null;
                        Console.WriteLine("==================================");
                        Console.WriteLine("★회차 정보가 초기화 되었습니다!★");
                        Console.WriteLine("==================================\n");
                    }
                    mainInst.Page -= 1;
                    break;

                case 3: // 인원선택 roundPeople -> 상영회차 선택 movieRound
                    mainInst.MainPanel.Controls.Remove(uc3_roundPeople.roundPeopleInst);
                    if (uc3_roundPeople.roundPeopleInst != null)
                    {
                        uc3_roundPeople.roundPeopleInst = null;
                        Console.WriteLine("==================================");
                        Console.WriteLine("★인원 선택이 초기화 되었습니다!★");
                        Console.WriteLine("==================================\n");
                    }

                    mainInst.MainPanel.Controls.Remove(uc2_movieRound.movieRoundInst);
                    uc2_movieRound.movieRoundInst = null;

                    Main.mainInst.MainPanel.Controls.Add(uc2_movieRound.movieRoundInst);
                    uc2_movieRound.movieRoundInst.BringToFront();

                    page -= 1;
                    break;

                case 4: // 좌석선택 seat -> 인원선택 roundPeople
                    uc4_seat.seatInst.ssReset();
                    mainInst.MainPanel.Controls.Remove(uc4_seat.seatInst);
                    if (uc4_seat.seatInst != null)
                    {
                        uc4_seat.seatInst = null;
                        Console.WriteLine("==================================");
                        Console.WriteLine("★좌석 선택이 초기화 되었습니다!★");
                        Console.WriteLine("==================================\n");
                    }


                    mainInst.MainPanel.Controls.Remove(uc3_roundPeople.roundPeopleInst);
                    uc3_roundPeople.roundPeopleInst = null;

                    mainInst.MainPanel.Controls.Add(uc3_roundPeople.roundPeopleInst);
                    uc3_roundPeople.roundPeopleInst.BringToFront();



                    uc3_roundPeople.roundPeopleInst.rpReset();
                    page -= 1;
                    break;
                case 5: // 할인선택 addDis -> 좌석선택 seat
                    mainInst.MainPanel.Controls.Remove(uc5_addDis.addDisInst);
                    if (uc5_addDis.addDisInst != null)
                    {
                        uc5_payment.uc5w1_selectTel.sltInst = null;
                        uc5_addDis.addDisInst = null;
                        Console.WriteLine("==================================");
                        Console.WriteLine("★할인 선택이 초기화 되었습니다!★");
                        Console.WriteLine("==================================\n");
                    }
                    syncDB();
                    if (uc4_seat.seatInst.TicketID != null)
                    {
                        uc4_seat.seatInst.terminateTicket();
                    }
                    mainInst.MainPanel.Controls.Remove(uc4_seat.seatInst);
                    uc4_seat.seatInst = null;
                    
                    mainInst.MainPanel.Controls.Add(uc4_seat.seatInst);
                    uc4_seat.seatInst.BringToFront();

                    uc4_seat.seatInst.reset_Click(sender, e);

                    page -= 1;
                    break;

            }
        }
        
        // 처음화면
        public void goHome_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(uc1_bookedPrint.Ticketid)))
            {
                if (mainInst.Page > 4)
                {
                    // uc5 초기화
                    syncDB();
                    mainInst.MainPanel.Controls.Remove(uc5_addDis.addDisInst);
                    uc5_payment.uc5w1_selectTel.sltInst = null;
                    uc5_addDis.addDisInst = null;
                }
                if (mainInst.Page > 3)
                {
                    //uc4 초기화

                    if ((uc4_seat.seatInst.TicketID != null))
                    {
                        terminateTicket();
                    }
                    uc4_seat.seatInst.reset_Click(sender, e);
                    uc4_seat.seatInst.ssReset();
                     
                }

                mainInst.MainPanel.Controls.Remove(uc4_seat.seatInst);
                uc4_seat.seatInst = null;


                if (mainInst.Page > 2)
                {
                    //uc3 초기화
                    uc3_roundPeople.roundPeopleInst.rpReset();
                    mainInst.MainPanel.Controls.Remove(uc3_roundPeople.roundPeopleInst);
                    uc3_roundPeople.roundPeopleInst = null;
                }
                //uc2 초기화
                mainInst.MainPanel.Controls.Remove(uc2_movieRound.movieRoundInst);
                uc2_movieRound.movieRoundInst = null;
            }
            //uc1 감추기
            uc1_bookedPrint.bookedPrintInst.BookedTicket.Controls.Remove(uc1_catalog.prepaidBar.prepaidBarInst);
            mainInst.MainPanel.Controls.Remove(uc1_bookedPrint.bookedPrintInst);
            
            uc1_bookedPrint.bookedPrintInst = null;
            uc1_catalog.prepaidBar.prepaidBarInst = null;
            
            Console.WriteLine("=============================");
            Console.WriteLine("★예매가 초기화 되었습니다!★");
            Console.WriteLine("=============================\n");

            mainInst.homePanel.BringToFront();
            mainInst.Page = 0;
        }
        
        #endregion

        #endregion

    }
}
