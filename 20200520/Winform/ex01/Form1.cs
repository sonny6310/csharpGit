using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // [디자인] 에서 만든 버튼
            button1.Text = "버튼"; // 이름
            button1.AutoSize = true; // 사이즈

            for (int i = 0; i < 5; i++)
            {
                // [디자인] 말고 cs창에서 버튼 추가하기
                Button button = new Button(); // 생성
                Controls.Add(button); // 추가

                // 위치
                Point point = new Point(); 
                point.X = 13;
                point.Y = 100 + 13 + (23 + 3) * i;
                button.Location = point;

                //button.Location = new Point(13, 13 + 23 + 3); // 위치

                button.Text = "코드상에서 생성 버튼"+(i+1); // 이름
                button.AutoSize = true; // 사이즈

                Random rand = new Random();
                bool visible = rand.Next(2) == 0 ? false : true; // 난수 0과 1생성하고 0이면 false, 1이면 true 저장
                Thread.Sleep(10); // 메소드를 호출한 스레드는 주어진 시간 동안 일시 정지 상태가 되고, 다시 실행 대기 상태로 돌아간다. (밀리세컨드)
                button.Visible = visible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Text = random.NextDouble().ToString();
        }
    }
}
