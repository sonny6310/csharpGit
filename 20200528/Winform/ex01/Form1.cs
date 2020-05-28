using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //인스턴스메소드 방식
            Cal cal = new Cal();
            label1.Text = cal.Power(3).ToString();
            label2.Text = cal.Power(3, 5).ToString();
            label3.Text = cal.SumAll(10).ToString();
            label4.Text = cal.SumAll(20, 30).ToString();

            //클래스메소드 방식
            label5.Text = Cal2.Power(3).ToString();
            label6.Text = Cal2.Power(3, 5).ToString();
            label7.Text = Cal2.SumAll(10).ToString();
            label8.Text = Cal2.SumAll(20, 30).ToString();

            // 참고 : label1.Text = Cal.Power(3).ToString(); 혹은 Cal().Power(3).ToString(); 등은 오류
            // Cal내부는 인스턴스메소드 이므로 클래스메소드처럼 사용 불가하기 때문

            // 마찬가지로 Cal2 c = new Cal2();  label1.Text = c.Power(3).ToString(); 혹은 label1.Text = new Cal2().Power(3).ToString(); 등은 오류
            // 클래스매소드를 인스턴스메소드처럼 사용할 수 없음
        }
    }
}
