using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02
{
    public partial class Form1 : Form
    {
        class GameCharacter
        {
            public static int mCountOfMember = 0;
            // 클래스변수(static) : 클래스명.변수명으로 바로 사용가능 , 클래스가 로딩될 때 생성됨(메모리에 단 한번 할당됨)
            public string mId;
            // 인스턴스변수 : 객체를 생성한 후에 객체명.변수명으로 사용가능 , 객체를 생성할 때 마다 생성됨(생성될 때 마다 메모리할당).
            public GameCharacter()
            {
                mCountOfMember++;
            }
        }
        public Form1()
        {
            InitializeComponent();
            GameCharacter one = new GameCharacter() { mId = "아이디1" }; // 객체생성
            GameCharacter two = new GameCharacter() { mId = "아이디2" };

            List<string> idList = new List<string>();
            idList.Add(one.mId);  // one.mId(인스턴스변수) : 객체명.변수명으로 사용함 
            idList.Add(two.mId);

            for (int i = 0; i < idList.Count; i++)
            {
                Label label = new Label();
                label.Text = idList[i];
                label.Location = new Point(10, 10 + (30 * i));
                Controls.Add(label);
            }

            MessageBox.Show($"이 게임의 총 회원수는 {GameCharacter.mCountOfMember}"); // GameCharacter.mCountOfMenber(클래스변수) : 클래스명.변수명으로 바로 사용함
        }
    }
}
