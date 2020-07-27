using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK_v1.uc1_catalog
{
    public partial class columnBar : UserControl
    {
        #region 객체
        public columnBar()
        {
            InitializeComponent();
        }

        static columnBar columnBarObj;           // columnBar 의 객체 선언
        public static columnBar columnBarInst // columnBarObj 의 인스턴스
        {
            get { return columnBarObj; }
            set { columnBarObj = value; }
        }
        #endregion

        #region 함수

        // 바 타입에 정보 채우기
        public void fillBar()   
        {
            if (uc1_movieList.movieListInst.CTitle == "")
            {
                barDateOrTime.Text = "--" + uc1_movieList.movieListInst.CDate + "--";
                barDateOrTime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                barTitle.Visible = false;
                barLine.Visible = false;
                barRuntime.Visible = false;
                barMin.Visible = false;
                barRating.Visible = false;
                barPoster.Visible = false;
                barPoster.Enabled = false;
                Size = new System.Drawing.Size(353, 45);
            }
            else { 

                barDateOrTime.Text = uc1_movieList.movieListInst.CTime;

                barTitle.Text = uc1_movieList.movieListInst.CTitle;
                barRuntime.Text = uc1_movieList.movieListInst.CRuntime;

                Image imageM = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Poster\" + uc1_movieList.movieListInst.Mcode + ".jpg");
                barPoster.BackgroundImage = imageM;
                barPoster.Tag = uc1_movieList.movieListInst.Mcode;

                Image imageR = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Menu\" + uc1_movieList.movieListInst.CRating + ".png");
                barRating.BackgroundImage = imageR;

                //★Solution 위치 경로★
                //System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName

                //★System 및 App 기준 경로★
                //System.IO.Directory.GetCurrentDirectory()
                //System.Environment.CurrentDirectory
                //Application.StartupPath
            }
            int n = uc1_movieList.movieListInst.BarNum;
            uc1_movieList.movieListInst.StackPanel.Controls.Add(columnBarInst);
            columnBarInst.Location = new System.Drawing.Point(0, 0 + 93 * n - 48 * (n - uc1_movieList.movieListInst.RoundBar));
        }

        // 포스터 클릭하면 회차선택으로 넘어감
        private void barPoster_Click(object sender, EventArgs e)
        {
            uc1_movieList.movieListInst.Mcode = barPoster.Tag.ToString();
            uc2_movieRound MovieRoundObj = new uc2_movieRound();
            Main.mainInst.MainPanel.Controls.Add(uc2_movieRound.movieRoundInst);
            uc2_movieRound.movieRoundInst.BringToFront();
            Main.mainInst.Page += 1;
        }
        
        #endregion
    }
}
