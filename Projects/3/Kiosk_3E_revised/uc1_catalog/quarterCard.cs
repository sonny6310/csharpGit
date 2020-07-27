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

namespace KIOSK_v1.uc1_catalog
{
    public partial class quarterCard : UserControl
    {
        #region 클래스
        public quarterCard()
        {
            InitializeComponent();
            quarterCardObj = this;
        }

        static quarterCard quarterCardObj;           // qaurterCard 의 객체 선언
        public static quarterCard quarterCardInst  // qaurterCardObj 의 인스턴스
        {
            get
            {
                if (quarterCardObj == null)
                {
                    quarterCardObj = new quarterCard(); 
                }
                return quarterCardObj;
            }
            set { quarterCardObj = value; }
        }
        #endregion

        #region 함수

        // 카드 타입 영화정보 채우기
        public void fillCard()
        {
            cardTitle.Text = uc1_movieList.movieListInst.CTitle;

            Image imageM = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Poster\" + uc1_movieList.movieListInst.Mcode + ".jpg");
            cardPoster.BackgroundImage = imageM;
            cardPoster.Tag = uc1_movieList.movieListInst.Mcode;

            Image imageR = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Menu\" + uc1_movieList.movieListInst.CRating + ".png");
            cardRating.BackgroundImage = imageR;

            cardRuntime.Text = uc1_movieList.movieListInst.CRuntime;

            //★Solution 위치 경로★
            //System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName

            //★System 및 App 기준 경로★
            //System.IO.Directory.GetCurrentDirectory()
            //System.Environment.CurrentDirectory
            //Application.StartupPath

            int n = uc1_movieList.movieListInst.CardNum;
            uc1_movieList.movieListInst.QuarterPanel.Controls.Add(quarterCardInst);
            quarterCardInst.Location = new System.Drawing.Point(0+185*(1-n%2), 0+263*(int)((n-1)/2));

        }

        // 카드 타입 포스터 클릭시 회차선택으로 넘어감
        private void cardPoster_Click(object sender, EventArgs e)
        {
            uc1_movieList.movieListInst.Mcode = cardPoster.Tag.ToString();
            uc2_movieRound MovieRoundObj = new uc2_movieRound();
            Main.mainInst.MainPanel.Controls.Add(uc2_movieRound.movieRoundInst);
            uc2_movieRound.movieRoundInst.BringToFront();
            Main.mainInst.Page += 1;
        }

        #endregion
    }
}



