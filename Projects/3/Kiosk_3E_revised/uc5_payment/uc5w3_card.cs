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

namespace KIOSK_v1.uc5_payment
{
    public partial class uc5w3_card : UserControl
    {

        #region 클래스
        public uc5w3_card()
        {
            InitializeComponent();
            cardObj = this;
        }
        static uc5w3_card cardObj;           // uc5w3_Card 의 객체 선언
        public static uc5w3_card cardInst // cardObj 의 인스턴스 생성
        {
            get
            {
                if (cardObj == null)
                {
                    cardObj = new uc5w3_card();
                }
                return cardObj;
            }
            set
            {
                cardObj = value;
            }
        }
        #endregion

        #region 변수
        public string paidTime { get { return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); } } // 결제완료 시간
        #endregion

        #region 함수

        // 결제완료버튼 누르면 티켓 인쇄창으로 이동
        private void paidCard_Click(object sender, EventArgs e)
        {
            try
            {
                Main.conn.Open();
                string sql = "UPDATE InfoTicket SET  money= '" + uc5_addDis.addDisInst.Total +"', " +
                    "payment = '신용카드', paidTime = '"+ cardInst.paidTime + "', chkPoint = '" + uc5_addDis.addDisInst.disDetail.Text + "', printed = 'Y'" +
                    "WHERE ticketID = '" + uc4_seat.seatInst.TicketID + "';";
                SqlCommand cmd = new SqlCommand(sql, Main.conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("\n결제정보 입력 성공");

                Main.conn.Close();
                Main.mainInst.MainPanel.Controls.Add(uc6_complete.completeInst);
                uc6_complete.completeInst.BringToFront();
                Main.mainInst.BottomPanel.SendToBack();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("결제정보 입력 실패 : " + ex.Message);
                return;
            }
            finally
            {
                Main.conn.Close();
            }
        }

        // 결제수단 변경 aka 이전화면
        private void cancelCard_Click(object sender, EventArgs e)
        {
            Main.mainInst.TurnBack.Visible = false;
            Main.mainInst.TurnBack.Enabled = false;
            Main.mainInst.GoHome.Visible = false;
            Main.mainInst.GoHome.Enabled = false;
            uc5_addDis.addDisInst.Controls.Remove(cardInst);
        }

        #endregion
    }
}
