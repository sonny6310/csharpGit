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

namespace ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                //if (item.GetType() == typeof(Button))
                //{
                //    if (((Button)item).Text.Contains("번째"))
                //    {
                //        ((Button)item).Visible = false;
                //    }
                //}

                //if (item is Button)
                //{
                //    if (((Button)item).Text.Contains("번째"))
                //    {
                //        ((Button)item).Visible = false;
                //    }
                //}

                //if(item is Button)
                //{
                //    if ((item as Button).Text.Contains("번째"))
                //    {
                //        (item as Button).Visible = false;
                //    }
                //}

                var btn = item as Button;  // item이 버튼이 아니면 null값 반환. item이 버튼이라면 btn = (Button)item.
                if (btn != null && btn.Text.Contains("번째"))
                {
                    btn.Visible = false;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Location = new Point(13, 80 + (26) * i);
                button.Text = $"{i + 1}번째 생성";
                button.Width = 260;

                Random rand = new Random();
                bool visible = rand.Next(0, 2) == 0 ? false : true;
                Thread.Sleep(10);
                button.Visible = visible;

                Controls.Add(button);
            }
        }
    }
}
