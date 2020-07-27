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
    public partial class uc5w1_selectTel : UserControl
    {

        #region 클래스
        public uc5w1_selectTel()
        {
            InitializeComponent();
            sltObj = this;
            A = 0;
            uc5_addDis.addDisInst.fillDetail();

        }
        static uc5w1_selectTel sltObj;        // uc5w_selectTel 의 객체 선언
        public static uc5w1_selectTel sltInst // sltObj 의 인스턴스 생성
        {
            get
            {
                if (sltObj == null)
                {
                    sltObj = new uc5w1_selectTel();
                }
                return sltObj;
            }
            set { sltObj = value; }
        }
        #endregion

        #region 변수
        static string telecom;  // 통신사
        public string Telecom
        {
            get { return telecom; }
            set { telecom = value; }
        }

        static double a;   // 통신사 할인률
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        #endregion

        #region 함수

        // 통신사별 할인율 적용
        private void KT_Click(object sender, EventArgs e)
        {
            // KT 할인
            sltInst.A = 0.2;
            uc5_addDis.addDisInst.Dis = (int.Parse(uc5_addDis.addDisInst.Sum) * sltInst.A).ToString();
            // SUM이 string 으로 선언되어 Parse 로 형변환
        }
        private void SKT_Click(object sender, EventArgs e)
        {
            // SKT 할인
            sltInst.A = 0.15;
            uc5_addDis.addDisInst.Dis = (int.Parse(uc5_addDis.addDisInst.Sum) * sltInst.A).ToString();
        }
        private void LG_Click(object sender, EventArgs e)
        {
            // LG 할인
            sltInst.A = 0.1;
            uc5_addDis.addDisInst.Dis = (int.Parse(uc5_addDis.addDisInst.Sum) * sltInst.A).ToString();
        }

        // 할인 적용 취소
        private void cancel_Click(object sender, EventArgs e)
        {
            uc5_addDis.addDisInst.Dis = "";
            uc5_addDis.addDisInst.Total = uc4_seat.seatInst.sum.Text;
            uc5_addDis.addDisInst.Controls.Remove(sltInst);
            sltObj = null;

            Main.mainInst.TurnBack.Visible = true;
            Main.mainInst.TurnBack.Enabled = true;
            Main.mainInst.GoHome.Visible = true;
            Main.mainInst.GoHome.Enabled = true;
            
            sltInst.A = 0;
            uc5_addDis.addDisInst.disDetail.Text.Replace("KT 멤버쉽", "");
            uc5_addDis.addDisInst.disDetail.Text.Replace("SKT 멤버쉽", "");
            uc5_addDis.addDisInst.disDetail.Text.Replace("LG 멤버쉽","");
            uc5_addDis.addDisInst.disDetail.Text.Replace(",", "");

            uc5_addDis.addDisInst.fillDetail();
        }

        // 할인 실제 적용
        private void confirm_Click(object sender, EventArgs e)
        { 
            // 할인 완료 후 창 닫기 
            if(uc5_addDis.addDisInst.Dis == "")
            {
                MessageBox.Show("통신사를 선택해주세요!");
            }
            else{
                uc5_addDis.addDisInst.Total = (int.Parse(uc5_addDis.addDisInst.Sum) - double.Parse(uc5_addDis.addDisInst.Dis)).ToString();
                uc5_addDis.addDisInst.Controls.Remove(sltInst);

                Main.mainInst.TurnBack.Visible = true;
                Main.mainInst.TurnBack.Enabled = true;
                Main.mainInst.GoHome.Visible = true;
                Main.mainInst.GoHome.Enabled = true;
                
                sltInst.Telecom = A.ToString();
            }
            uc5_addDis.addDisInst.fillDetail();
        }

        #endregion 
    }
}
