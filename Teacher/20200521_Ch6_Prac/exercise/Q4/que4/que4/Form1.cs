using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace que4
{
    public partial class Form1 : Form
    {
        List<string> text = new List<string>()
        {
            "Sunt cupidatat esse mollit voluptate non ex qui Lorem nostrud id aute sunt dolor.",
            "한글도 있어야겠죠",
            "Officia est ea magna et amet.",
            "Lorem Ipsum은 다양한 언어가 있습니다만, 한글은 없는 것 같습니다.",
            "Elit eiusmod ut eiusmod labore et cillum nisi adipisicing laboris sunt culpa cupidatat."
        };
        public Form1()
        {
            InitializeComponent();

            text.Add("Incididunt quis aliqua nisi do ex sunt minim.");
        }

        private void button_sentense_Click(object sender, EventArgs e)
        {
            label_sentense.Text = "";
            //0부터 (text의 길이-1) 에 해당하는 문장 출력
            label_sentense.Text = text[new Random().Next(text.Count)]; 
        }
    }
}
