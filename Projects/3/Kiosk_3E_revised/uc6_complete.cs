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
    public partial class uc6_complete : UserControl
    {

        #region 클래스
        public uc6_complete()
        {
            InitializeComponent();
            completeObj = this;

            QRCodeGenerator qr = new QRCodeGenerator();
            if (Main.mainInst.Page == 5)
            {
                QRCodeData data = qr.CreateQrCode(uc4_seat.seatInst.TicketID, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                QRCodeImage.Image = code.GetGraphic(4);

                movieTitle.Text = uc4_seat.seatInst.Title;
                roundTime.Text = uc4_seat.seatInst.Date + " / " + uc4_seat.seatInst.Time;
                hall.Text = uc4_seat.seatInst.HallNum + "관";
                seat.Text = uc4_seat.seatInst.Selected;
                chkPoint.Text = uc5_addDis.addDisInst.disDetail.Text;
            }
        }
        static uc6_complete completeObj;           // uc8_Complete 의 객체 선언
        public static uc6_complete completeInst // completeObj 의 인스턴스 생성
        {
            get
            {
                if (completeObj == null)
                {
                    completeObj = new uc6_complete();
                }
                return completeObj;
            }
            set
            {
                completeObj = value;
            }
        }
        #endregion


        #region 변수
        public QRCodeData QRCodeDada { get; private set; }  // QR 코드
        #endregion

        #region 함수

        // 처음화면
        private void doneGoHome_Click(object sender, EventArgs e)
        {
            Main.mainInst.GoHome.Enabled = true;
            Main.mainInst.goHome_Click(sender, e);
        }

        #endregion
    }
}
