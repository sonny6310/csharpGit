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
using System.Text.RegularExpressions;   // string 내 특정 문자개수 세기 위한 설정

namespace KIOSK_v1
{
    public partial class uc2_movieRound : UserControl
    {
        #region 클래스
        public uc2_movieRound()
        {
            InitializeComponent();

            movieRoundObj = this;
            movieRoundInst.fillSelectedMovie();
            movieRoundInst.fillCombobox();
        }
        static uc2_movieRound movieRoundObj;        // uc2_movieRound 의 객체 선언
        public static uc2_movieRound movieRoundInst // MovieRoundObj 의 인스턴스 
        {
            get
            {
                if (movieRoundObj == null)
                {
                    movieRoundObj = new uc2_movieRound();
                }
                return movieRoundObj;
            }
            set { movieRoundObj = value; }
        }
        #endregion

        #region 변수
        
        // 콤보박스간 정보전달을 위한 날짜
        string date { get { return movieRoundInst.cbDate.Text; } set { movieRoundInst.cbDate.Text = value; } }
        string time { get { return movieRoundInst.cbRound.Text; } set { movieRoundInst.cbRound.Text = value; } }
       
        int hallNum;    //  상영관
        int seatMax;    //  최대 좌석수
        int cnt;    //  booked 상의 "," 개수 

        static int leftSeatNum; // 잔여좌석 수
        public int LeftSeatNum
        {
            get { return leftSeatNum; }
            set { leftSeatNum = value; }
        }

        static int bookedNum;  //  예매완료 수 선언 및 접근 허용
        public int BookedNum
        {
            get { return bookedNum; }
            set { bookedNum = value; }
        }

        static string booked;  //  예매완료 좌석 선언 및 접근 허용
        public string Booked
        {
            get { return booked; }
            set { booked = value; }
        }

        static string roundID;  // 회차ID 선언 및 접근 허용
        public string RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }

        #endregion

        #region 함수

        // 선택 영화 정보 채우기
        public void fillSelectedMovie()
        {
            try
            {
                Console.WriteLine("선택한 영화");
                Console.WriteLine("----------------");

                Main.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * fROM InfoFilm WHERE mcode = '" + uc1_movieList.movieListInst.Mcode + "';", Main.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    title1.Text = row["title"].ToString();

                    Image imageM = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Poster\" + uc1_movieList.movieListInst.Mcode + ".jpg");
                    movie1.BackgroundImage = imageM;

                    string Rating = row["rating"].ToString();
                    Image imageR = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Menu\" + Rating + ".png");
                    rating1.BackgroundImage = imageR;

                    runtime1.Text = row["runTime"].ToString();
                }

                Console.WriteLine("선택한 영화 정보 완성");
                Main.conn.Close();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("선택한 영화 정보 입력 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }

        }

        // 날짜 콤보박스 채우기
        public void fillCombobox()
        {
            try
            {
                movieRoundInst.cbDate.Items.Clear();
                movieRoundInst.cbRound.Items.Clear();
                Main.conn.Open();
                string sql = "SELECT DISTINCT date FROM InfoRunde WHERE mcode = '" + uc1_movieList.movieListInst.Mcode + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    cbDate.Items.Add(row["date"].ToString());
                }
                Console.WriteLine("상영일자 목록 완성\n");
                Main.conn.Close();
                return;

            }

            catch (Exception ex)
            {
                Console.WriteLine("상영일자 입력 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 해당 날짜에 따른 시간 콤보박스 채우기
        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("상영일자 선택");
                movieRoundInst.cbRound.Items.Clear();
                Main.conn.Open();
                string sql = "SELECT DISTINCT time fROM InfoRunde WHERE mcode = '" + uc1_movieList.movieListInst.Mcode + "' and date = '" + date + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    cbRound.Items.Add(row["time"].ToString());
                }
                Console.WriteLine("상영시간 목록 완성\n");
                Main.conn.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("상영시간 입력 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        //시간 클릭하면 해당영화의 날짜에 시간에 해당하는 예매가능한 좌석수 표시
        private void cbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("상영시간 선택\n");
                Main.conn.Open();
                string sql = "SELECT * fROM InfoRunde WHERE mcode = '"
                              + uc1_movieList.movieListInst.Mcode + "' and date = '" + date + "' and time = '" + time + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    movieRoundInst.RoundID = row["roundID"].ToString();
                    Console.WriteLine("회차 ID :\t" + movieRoundInst.RoundID + "");

                    string hall = row["hallNum"].ToString();
                    movieRoundInst.hallNum = Convert.ToInt32(hall);
                    Console.WriteLine("상 영 관 :\t" + movieRoundInst.hallNum + "관\n");

                    movieRoundInst.Booked = row["booked"].ToString();
                }

                sql = "SELECT seatMax fROM InfoHall WHERE hallNum = '" + movieRoundInst.hallNum + "';";

                cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (String.IsNullOrEmpty(movieRoundInst.Booked))
                {
                    movieRoundInst.BookedNum = 0;
                }
                else
                {
                    MatchCollection matches = Regex.Matches(movieRoundInst.Booked, ",");
                    cnt = matches.Count;

                    if (cnt == 0)
                    {
                        movieRoundInst.BookedNum = 1;
                    }
                                        
                    else
                    {
                        movieRoundInst.BookedNum = cnt + 1;
                    }
                }
                
                string seat = dt.Rows[0][0].ToString();
                seatMax = Convert.ToInt32(seat);

                if (seatMax - cnt == 1)
                {
                    seatNow.Text = "없음";
                }
                else
                {
                    movieRoundInst.LeftSeatNum = seatMax - bookedNum;
                    seatNow.Text = movieRoundInst.LeftSeatNum.ToString() + " / " + seatMax.ToString();
                }
                
                Main.conn.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("잔여좌석 입력 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        //좌석 선택 페이지로 이동
        private void goSelectSeat_Click(object sender, EventArgs e)
        {
            if (seatMax - cnt == 1)
            {
                MessageBox.Show("잔여좌석이 없습니다.\n다시 선택해 주십시오.");
            }
            else if (cbDate.Text == "상영일자")
            {
                MessageBox.Show("상영일자를 선택하세요");
            }
            else if (cbRound.Text == "상영시간")
            {
                MessageBox.Show("상영시간을 선택하세요");
            }
            else
            {


                Main.mainInst.MainPanel.Controls.Add(uc3_roundPeople.roundPeopleInst);
                uc3_roundPeople.roundPeopleInst.BringToFront();
                uc3_roundPeople.roundPeopleInst.rpReset();
                Main.mainInst.Page += 1;
            }
        }

        #endregion
    }
}
