using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK_v1.uc5_payment
{
    public partial class uc5w2_selectPay : UserControl
    {

        #region 클래스
        public uc5w2_selectPay()
        {
            InitializeComponent();
            selectPayObj = this;
            
        }
        static uc5w2_selectPay selectPayObj;           // uc5w2_selectPay 의 객체 선언
        public static uc5w2_selectPay selectPayInst // selectPayObj 의 인스턴스 생성
        {
            get
            {
                if (selectPayObj == null)
                {
                    selectPayObj = new uc5w2_selectPay();
                }
                return selectPayObj;
            }
            set
            {
                selectPayObj = value;
            }
        }
        #endregion

        #region 함수

        // 신용카드 선택
        private void creditCard_Click(object sender, EventArgs e)
        {
            uc5_addDis.addDisInst.Controls.Add(uc5w3_card.cardInst);
            uc5w3_card.cardInst.Location = new Point(0, 261);
            uc5w3_card.cardInst.BringToFront();

            Main.mainInst.TurnBack.Visible = false;
            Main.mainInst.TurnBack.Enabled = false;
            Main.mainInst.GoHome.Visible = false;
            Main.mainInst.GoHome.Enabled = false;
        }

        // 카카오페이 선택
        private void kakaoPay_Click(object sender, EventArgs e)
        {
            uc5_addDis.addDisInst.Controls.Add(uc5w3_kakao.kakaoInst);
            uc5w3_kakao.kakaoInst.Location = new Point(0, 261);
            uc5w3_kakao.kakaoInst.BringToFront();

            Main.mainInst.TurnBack.Visible = false;
            Main.mainInst.TurnBack.Enabled = false;
            Main.mainInst.GoHome.Visible = false;
            Main.mainInst.GoHome.Enabled = false;
        }

        // 할인적용 수정 aka 이전 화면
        private void changeDiscount_Click(object sender, EventArgs e)
        {
            Main.mainInst.TurnBack.Visible = true;
            Main.mainInst.TurnBack.Enabled = true;
            Main.mainInst.GoHome.Visible = true;
            Main.mainInst.GoHome.Enabled = true;
            uc5_addDis.addDisInst.Controls.Remove(selectPayInst);
        }

        #endregion
    }
}
