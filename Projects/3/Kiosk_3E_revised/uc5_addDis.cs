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
    public partial class uc5_addDis : UserControl
    {
        #region 클래스
        static uc5_addDis addDisObj;        // uc5_addDis 의 객체 선언
        public static uc5_addDis addDisInst // AddDisObj 의 인스턴스 생성
        {
            get
            {
                if (addDisObj == null)
                {
                    addDisObj = new uc5_addDis();
                }
                return addDisObj;
            }
            set { addDisObj = value; }
        }
        public uc5_addDis()
        {
            InitializeComponent();
            addDisObj = this;
            addDisInst.Dis = "";
            addDisInst.total.Text = uc4_seat.seatInst.sum.Text;    // 금액 uc5_addDis 로 넘기기
            addDisInst.sum.Text = uc4_seat.seatInst.sum.Text;

            progressNow.Text = uc4_seat.seatInst.Date + " / " + uc4_seat.seatInst.Time + "\n" + uc4_seat.seatInst.HallNum + "관 / " +
                uc4_seat.seatInst.Title + "  예매중입니다.";
        }
        #endregion

        #region 변수
        public string Dis { get { return dis.Text; } set { dis.Text = value; } } // 할인 금액
        public string Sum { get { return sum.Text; } set { sum.Text = value; } } // 좌석선택후 넘겨받은 금액
        public string Total { get { return total.Text; } set { total.Text = value; } } // 총금액
        #endregion

        #region 함수

        // 추가 할인 정보 채우기
        public void fillDetail()
        {
            if (uc3_roundPeople.roundPeopleInst.Youth != 0)
            {
                addDisInst.disDetail.Text = "청소년 " + uc3_roundPeople.roundPeopleInst.Youth + "명";
            }
            if (!(string.IsNullOrEmpty(addDisInst.disDetail.Text)) && !(string.IsNullOrEmpty(uc5_addDis.addDisInst.Dis)))
            {
                addDisInst.disDetail.Text += ", ";
            }
            switch (uc5_payment.uc5w1_selectTel.sltInst.A.ToString())
            {
                case "0":
                    if (uc3_roundPeople.roundPeopleInst.Youth != 0)
                    {
                        addDisInst.disDetail.Text = "청소년 " + uc3_roundPeople.roundPeopleInst.Youth + "명";
                    }
                    break;

                case "0.2":
                    addDisInst.disDetail.Text += "KT 멤버쉽";
                    break;

                case "0.15":
                    addDisInst.disDetail.Text += "SKT 멤버쉽";
                    break;

                case "0.1":
                    addDisInst.disDetail.Text += "LG 멤버쉽";
                    break;
            }
        }

        //통신사 할인창 팝업
        private void telecomDis_Click(object sender, EventArgs e)
        {
            addDisInst.Dis = "";
            addDisInst.Total = "";

            addDisInst.Controls.Add(uc5_payment.uc5w1_selectTel.sltInst);
            uc5_payment.uc5w1_selectTel.sltInst.Location = new Point(0, 301);
            uc5_payment.uc5w1_selectTel.sltInst.BringToFront();

            Main.mainInst.TurnBack.Visible = false;
            Main.mainInst.TurnBack.Enabled = false;
            Main.mainInst.GoHome.Visible = false;
            Main.mainInst.GoHome.Enabled = false;
        }

        // 결제수단 선택창 팝업
        private void payForIt_Click(object sender, EventArgs e)
        {
            addDisInst.Controls.Add(uc5_payment.uc5w2_selectPay.selectPayInst);
            uc5_payment.uc5w2_selectPay.selectPayInst.Location = new Point(0, 301);
            uc5_payment.uc5w2_selectPay.selectPayInst.BringToFront();

            Main.mainInst.TurnBack.Visible = false;
            Main.mainInst.TurnBack.Enabled = false;
            Main.mainInst.GoHome.Visible = false;
            Main.mainInst.GoHome.Enabled = false;
        }

        #endregion
    }
}
