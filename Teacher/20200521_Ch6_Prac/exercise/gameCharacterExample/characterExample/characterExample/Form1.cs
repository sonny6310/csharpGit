using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace characterExample
{
    public partial class Form1 : Form
    {
        class GameCharacter
        {
            public static int mCountOfMember = 0;
            public string mId;

            public GameCharacter()
            {
                mCountOfMember++;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Product p = new Product();

            TestClass t = new TestClass();
            t.test = 1;
            TestClass t2 = new TestClass();
            t2.test = 2;
            TestClass.tester = 5;


            GameCharacter leedongjoon = new GameCharacter() { mId = "ldj" };
            GameCharacter dongjoonlee = new GameCharacter() { mId = "djl" };

            List<string> idList = new List<string>();
            idList.Add(leedongjoon.mId);
            idList.Add(dongjoonlee.mId);

            //int[] example = new int[3];

            for(int i = 0; i < idList.Count; i++)
            {
                Label label = new Label();
                label.Text = idList[i];
                label.Location = new Point(13, 13+(23+3)*i);
                Controls.Add(label);
            }

            MessageBox.Show($"이 게임의 총 회원수는 {GameCharacter.mCountOfMember}명 입니다.");
        }
    }
}
