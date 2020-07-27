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
    public partial class uc1_movieList : UserControl
    {

        #region 클래스
        public uc1_movieList()
        {
            InitializeComponent();
        }
        static uc1_movieList movieListObj;           // uc1_movieList 의 객체 선언
        public static uc1_movieList movieListInst // movieListObj 의 인스턴스
        {
            get
            {
                if (movieListObj == null)
                {
                    movieListObj = new uc1_movieList();
                }
                return movieListObj;
            }
            set
            {
                movieListObj = value;
            }
        }
        #endregion

        #region 변수 및 객체
        
        // 영화코드 접근 허용
        static string mcode, cTitle, cRating, cDate, cTime, cRuntime;
        public string Mcode
        {
            get { return mcode; }
            set { mcode = value; }
        }
        public string CTitle
        {
            get { return cTitle; }
            set { cTitle = value; }
        }
        public string CRating
        {
            get { return cRating; }
            set { cRating = value; }
        }
        public string CDate
        {
            get { return cDate; }
            set { cDate = value; }
        }
        public string CTime
        {
            get { return cTime; }
            set { cTime = value; }
        }
        public string CRuntime
        {
            get { return cRuntime; }
            set { cRuntime = value; }
        }

        // quarterPanel 접근 허용
        public Panel QuarterPanel
        {
            get { return quarterPanel; }
            set { quarterPanel = value; }
        }

        // quarterCard 번호
        static int cardNum;
        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        
        // stackPanel 접근허용
        public Panel StackPanel
        {
            get { return stackPanel; }
            set { stackPanel = value; }
        }

        // columnBar 번호
        static int barNum;
        public int BarNum
        {
            get { return barNum; }
            set { barNum = value; }
        }

        // columnBar 번호
        static int roundBar;
        public int RoundBar
        {
            get { return roundBar; }
            set { roundBar = value; }
        }

        #endregion

        #region 함수

        // 상영중인 영화정보만 채우기
        public void fillMovie()
        {
            
            try
            {
                
                Main.conn.Open();
                
                // 영화별 선택 채우기 
                string sqli = "SELECT DISTINCT mcode FROM InfoRunde;";
                SqlCommand cmdi = new SqlCommand(sqli, Main.conn);
                cmdi.ExecuteNonQuery();

                DataTable dti = new DataTable();
                SqlDataAdapter dai = new SqlDataAdapter(cmdi);
                dai.Fill(dti);

                cardNum = 0;
                foreach (DataRow dri in dti.Rows)
                {
                    string mcash = dri["mcode"].ToString();
                    string sqlj = "SELECT * FROM InfoFilm WHERE mcode = '" + mcash + "';";
                    SqlCommand cmdj = new SqlCommand(sqlj, Main.conn);
                    cmdj.ExecuteNonQuery();

                    DataTable dtj = new DataTable();
                    SqlDataAdapter daj = new SqlDataAdapter(cmdj);
                    daj.Fill(dtj);

                    
                    foreach (DataRow drj in dtj.Rows)
                    {
                        
                        uc1_catalog.quarterCard.quarterCardInst = new uc1_catalog.quarterCard();

                        cTitle = drj["title"].ToString();
                        mcode = mcash;

                        Console.WriteLine(++cardNum + "번 카드 : " + cTitle + " / " + mcash);

                        cRating = drj["rating"].ToString();
                        cRuntime = drj["runTime"].ToString();

                        uc1_catalog.quarterCard.quarterCardInst.fillCard();    // 카드타입 입력

                    }

                }
                Console.WriteLine("\n카드 타입 입력 완료\n");

                // 시간대별 선택 채우기
                barNum = 0;
                roundBar = 0;

                string sql1 = "SELECT DISTINCT date FROM InfoRunde;";
                SqlCommand cmd1 = new SqlCommand(sql1, Main.conn);
                cmd1.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                foreach (DataRow dr1 in dt1.Rows)
                {
                    string dcash = dr1["date"].ToString();
                    string sql2 = "SELECT * FROM InfoRunde WHERE date = '" + dcash + "' ORDER BY time; ";
                    SqlCommand cmd2 = new SqlCommand(sql2, Main.conn);
                    cmd2.ExecuteNonQuery();

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);

                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        
                        if (cDate != dcash)
                        {
                            uc1_catalog.columnBar.columnBarInst = new uc1_catalog.columnBar();
                            cDate = dcash;
                            cTitle = "";
                            uc1_catalog.columnBar.columnBarInst.fillBar(); // 바타입 날짜 입력
                            ++barNum;
                            Console.WriteLine("--- 날짜 구분 --- ");
                        }
                                                
                        uc1_catalog.columnBar.columnBarInst = new uc1_catalog.columnBar();
                        cTime = dr2["time"].ToString();

                        string mcash = dr2["mcode"].ToString();
                        mcode = mcash;

                        string sql3 = "SELECT * FROM InfoFilm WHERE mcode = '" + mcode + "';";
                        SqlCommand cmd3 = new SqlCommand(sql3, Main.conn);
                        cmd3.ExecuteNonQuery();

                        DataTable dt3 = new DataTable();
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                        da3.Fill(dt3);

                        foreach (DataRow dr3 in dt3.Rows)
                        {
                            cTitle = dr3["title"].ToString();
                            cRating = dr3["rating"].ToString();
                            cRuntime = dr3["runTime"].ToString();
                        }
                        uc1_catalog.columnBar.columnBarInst.fillBar(); // 바타입 입력                                                       
                        Console.WriteLine( ++roundBar+ "번 바 : " + cTitle + " / " + mcode);
                        ++barNum;
                    }
                }
                
                Console.WriteLine("\n바 타입 입력 완료");
                Console.WriteLine("");
                Main.conn.Close();
                Console.WriteLine();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine("영화 정보 입력 실패 : " + ex.Message);
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
