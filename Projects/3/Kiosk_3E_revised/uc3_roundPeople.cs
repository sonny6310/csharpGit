using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK_v1
{


    public partial class uc3_roundPeople : UserControl
    {

        #region 클래스
        public uc3_roundPeople()
        {
            InitializeComponent();
            roundPeopleObj = this;
            rpReset();
        }
        static uc3_roundPeople roundPeopleObj;        // uc3_roundPeople 의 객체 선언
        public static uc3_roundPeople roundPeopleInst // roundpeopleobj 의 인스턴스 생성
        {
            get
            {
                if (roundPeopleObj == null)
                {
                    roundPeopleObj = new uc3_roundPeople();
                }
                return roundPeopleObj;
            }
            set { roundPeopleObj = value; }
        }
        #endregion

        #region 변수
        static int adult = 0; // 성인수
        public int Adult
        {
            get { return adult; }
            set { adult = value; }
        }

        static int youth = 0; // 청소년 수
        public int Youth
        {
            get { return youth; }
            set { youth = value; }
        }

        static int person = 0; // 총 인원수
        public int Person
        {
            get { return person; }
            set { person = value; }
        }
                        
        public string InfoT { get; set; }   // 임시 성인 정보
        public string InfoT_Y { get; set; } // 임시 청소년 정보
        #endregion

        #region 함수

        // 인원선택 초기화
        public void rpReset()
        {
            setForeBackImageBtn();
            setForeBackImageBtn2();
            adult = 0;
            youth = 0;
            person = 0;
            Info.Text = "";
            Info_Y.Text = "";
        }
        
        //성인 인원 수 선택 함수
        private void btnPs_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (InfoT != "")
            {
                PictureBox btn2 = (PictureBox)sender;
                InfoT = btn2.Tag.ToString();
            }
            else { InfoT = btn.Tag.ToString(); }
            //버튼의 값 받아옴

            Info.Text = InfoT;  //출력창에 버튼의 tag값 text로 변경
            roundPeopleInst.Adult = Convert.ToInt32(Info.Text); //adult값 정수로 변환
            roundPeopleInst.Person = roundPeopleInst.Adult + roundPeopleInst.Youth;
        }

        //청소년 인원 수 선택 함수
        private void btnYt_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (InfoT_Y != "")
            {
                PictureBox btn2 = (PictureBox)sender;
                InfoT_Y = btn2.Tag.ToString();
            }
            else { InfoT_Y = btn.Tag.ToString(); }
            //버튼의 값 받아옴
            Info_Y.Text = InfoT_Y;    //출력창에 버튼의 tag값 text로 변경
            roundPeopleInst.Youth = Convert.ToInt32(Info_Y.Text);   //youth값 정수로 변환
            roundPeopleInst.Person = roundPeopleInst.Adult + roundPeopleInst.Youth;
        }

        //흰색 버튼 모두 앞으로 나오는 함수
        public void setForeBackImageBtn()
        {
            roundPeopleInst.a1.Image = Properties.Resources._1_unchk_26px;
            roundPeopleInst.a2.Image = Properties.Resources._2_unchk_26px;
            roundPeopleInst.a3.Image = Properties.Resources._3_unchk_26px;
            roundPeopleInst.a4.Image = Properties.Resources._4_unchk_26px;
            roundPeopleInst.a5.Image = Properties.Resources._5_unchk_26px;
            roundPeopleInst.a6.Image = Properties.Resources._6_unchk_26px;
        }
        public void setForeBackImageBtn2()
        {
            roundPeopleInst.y1.Image = Properties.Resources._1_unchk_26px;
            roundPeopleInst.y2.Image = Properties.Resources._2_unchk_26px;
            roundPeopleInst.y3.Image = Properties.Resources._3_unchk_26px;
            roundPeopleInst.y4.Image = Properties.Resources._4_unchk_26px;
            roundPeopleInst.y5.Image = Properties.Resources._5_unchk_26px;
            roundPeopleInst.y6.Image = Properties.Resources._6_unchk_26px;
        }
               
        //클릭할 때마다 버튼 색 바뀌면서 인원수 전달 (성인)
        private void a1_Click(object sender, EventArgs e)
        {
            // 해제
            if (InfoT == "1")
            {
                setForeBackImageBtn();
                roundPeopleInst.a1.Image = Properties.Resources._1_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }

            // 선택
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a1.Image = Properties.Resources._1_chk_26px;
                btnPs_Click(sender, e);
            }
        }
        private void a2_Click(object sender, EventArgs e)
        {
            if (InfoT == "2")
            {
                setForeBackImageBtn();
                roundPeopleInst.a2.Image = Properties.Resources._2_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a2.Image = Properties.Resources._2_chk_26px;
                btnPs_Click(sender, e);
            }
        }
        private void a3_Click(object sender, EventArgs e)
        {
            if (InfoT == "3")
            {
                setForeBackImageBtn();
                roundPeopleInst.a3.Image = Properties.Resources._3_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a3.Image = Properties.Resources._3_chk_26px;
                btnPs_Click(sender, e);
            }
        }
        private void a4_Click(object sender, EventArgs e)
        {
            if (InfoT == "4")
            {
                setForeBackImageBtn();
                roundPeopleInst.a4.Image = Properties.Resources._4_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a4.Image = Properties.Resources._4_chk_26px;
                btnPs_Click(sender, e);
            }
        }
        private void a5_Click(object sender, EventArgs e)
        {
            if (InfoT == "5")
            {
                setForeBackImageBtn();
                roundPeopleInst.a5.Image = Properties.Resources._5_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a5.Image = Properties.Resources._5_chk_26px;
                btnPs_Click(sender, e);
            }
        }
        private void a6_Click(object sender, EventArgs e)
        {
            if (InfoT == "6")
            {
                setForeBackImageBtn();
                roundPeopleInst.a6.Image = Properties.Resources._6_unchk_26px;
                btnPs_Click(sender, e);
                roundPeopleInst.Adult = 0;
                Info.Text = "";
                InfoT = "0";
            }
            else
            {
                setForeBackImageBtn();
                roundPeopleInst.a6.Image = Properties.Resources._6_chk_26px;
                btnPs_Click(sender, e);
            }
        }

        //클릭할 때마다 버튼 색 바뀌면서 인원수 전달 (청소년)
        private void y1_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "1")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y1.Image = Properties.Resources._1_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y1.Image = Properties.Resources._1_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        private void y2_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "2")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y2.Image = Properties.Resources._2_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y2.Image = Properties.Resources._2_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        private void y3_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "3")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y3.Image = Properties.Resources._3_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y3.Image = Properties.Resources._3_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        private void y4_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "4")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y4.Image = Properties.Resources._4_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y4.Image = Properties.Resources._4_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        private void y5_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "5")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y5.Image = Properties.Resources._5_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y5.Image = Properties.Resources._5_chk_26px;
                btnYt_Click(sender, e);
            }
        }
        private void y6_Click(object sender, EventArgs e)
        {
            if (InfoT_Y == "6")
            {
                setForeBackImageBtn2();
                roundPeopleInst.y6.Image = Properties.Resources._6_unchk_26px;
                btnYt_Click(sender, e);
                roundPeopleInst.Youth = 0;
                Info_Y.Text = "";
                InfoT_Y = "0";
            }
            else
            {
                setForeBackImageBtn2();
                roundPeopleInst.y6.Image = Properties.Resources._6_chk_26px;
                btnYt_Click(sender, e);
            }
        }

        // 선택 완료 버튼
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (roundPeopleInst.Adult == 0 && roundPeopleInst.Youth == 0) // 성인 청소년 둘다 0명이면
            {
                MessageBox.Show("인원을 선택하세요");
            }
            else if (((roundPeopleInst.Adult + roundPeopleInst.Youth) > uc2_movieRound.movieRoundInst.LeftSeatNum) || ((roundPeopleInst.Adult + roundPeopleInst.Youth) > 6))
            {   // 가용좌석보다 초과 입력시
                MessageBox.Show("선택할 수 있는 인원을 초과하였습니다");
            }
            else
            {
                if (Info.Text != "")
                    roundPeopleInst.Adult = Convert.ToInt32(Info.Text); //adult값 정수로 변환
                if (Info_Y.Text != "")
                    roundPeopleInst.Youth = Convert.ToInt32(Info_Y.Text);   //youth값 정수로 변환
                roundPeopleInst.Person = roundPeopleInst.Adult + roundPeopleInst.Youth;

                Console.WriteLine("필요한 티켓 수 : " + roundPeopleInst.Person);
                Console.WriteLine("------------------");
                Main.mainInst.MainPanel.Controls.Add(uc4_seat.seatInst);
                uc4_seat.seatInst.BringToFront();
                Main.mainInst.Page += 1;
            }
        }

        #endregion
    }
}
