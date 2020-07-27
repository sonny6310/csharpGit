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
    public partial class prepaidBar : UserControl
    {
        #region 클래스
        public prepaidBar()
        {
            InitializeComponent();
        }

        static prepaidBar prepaidBarObj;           // prepaidBar 의 객체 선언
        public static prepaidBar prepaidBarInst // prepaidBarObj 의 인스턴스
        {
            get { return prepaidBarObj; }
            set { prepaidBarObj = value; }
        }
        #endregion

        #region 변수
        public Label BarTitle
        {
            get { return barTitle; }
            set { barTitle = value; }
        }
        #endregion

        #region 함수

        // 바 타입 영화정보 채우기
        public void fillBar()
        {
                barDateOrTime.Text = uc1_bookedPrint.bookedPrintInst.dcash+"\n"+ uc1_bookedPrint.bookedPrintInst.tcash;
                barTitle.Text = uc1_bookedPrint.bookedPrintInst.title;
                barRuntime.Text = uc1_bookedPrint.bookedPrintInst.runtime;

                Image imageM = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Poster\" + uc1_bookedPrint.bookedPrintInst.mcash + ".jpg");
                barPoster.BackgroundImage = imageM;
                // barPoster.Tag = uc1_movieList.movieListInst.Mcode;

                Image imageR = Image.FromFile(System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\Properties\Resource_Menu\" + uc1_bookedPrint.bookedPrintInst.rating + ".png");
                barRating.BackgroundImage = imageR;

                //★Solution 위치 경로★
                //System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName

                //★System 및 App 기준 경로★
                //System.IO.Directory.GetCurrentDirectory()
                //System.Environment.CurrentDirectory
                //Application.StartupPath


         
            int n = uc1_bookedPrint.barnum;
            uc1_bookedPrint.bookedPrintInst.BookedTicket.Controls.Add(prepaidBarInst);
            prepaidBarInst.Location = new System.Drawing.Point(0, 0 + 93 * n - 52 * n);
        }

        // 바 포스터 클릭시 티켓 내용 표시
        private void barPoster_Click(object sender, EventArgs e)
        {
            uc1_bookedPrint.bookedPrintInst.movieTitle.Text = uc1_bookedPrint.bookedPrintInst.title;
            uc1_bookedPrint.bookedPrintInst.roundTime.Text = uc1_bookedPrint.bookedPrintInst.dcash + " / " + uc1_bookedPrint.bookedPrintInst.tcash;
            uc1_bookedPrint.bookedPrintInst.hall.Text = uc1_bookedPrint.bookedPrintInst.hcash + "관";
            uc1_bookedPrint.bookedPrintInst.seat.Text = uc1_bookedPrint.bookedPrintInst.scash;
            uc1_bookedPrint.bookedPrintInst.seat.Tag = uc1_bookedPrint.bookedPrintInst.ccash;
        }

        #endregion
    }
}
