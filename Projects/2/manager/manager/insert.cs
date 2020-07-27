using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class insert : Form
    {
        string image_file = string.Empty; //이미지를 담기위한 지역변수 생성

        public insert()
        {
            InitializeComponent();
        }

        //마우스 클릭 이동 (상단바)
        private Point mousePoint; 
        private void topP_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void topP_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e) //이미지 등록
        {
            string loot = Application.StartupPath.ToString(); //어플리케이션 실행 폴더 추출
            OpenFileDialog dialog = new OpenFileDialog(); //이미지 선택을 위한 다이얼로그
            dialog.InitialDirectory = @"D:\"; //다이얼 로그를 열었을때 보여줄 초기 위치 설정

            if (dialog.ShowDialog() == DialogResult.OK) // OK 선택한 이미지의 값을 image_file 변수에 대입
            {
                image_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel) //Cancel 해당 이벤트 종료
            {
                return;
            }

            int img_w = 180;
            int img_h = 180;

            Size resize = new Size(img_w, img_h);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // picturBox1에 맞춰 이미지 크기를 조절함
            pictureBox1.Image = Bitmap.FromFile(image_file); //picturBox1에 선택한 이미지를 넣음}
            string pic = name_textbox.Text;
            if(!System.IO.Directory.Exists(loot+ "\\menu_img\\"))
            {
                System.IO.Directory.CreateDirectory(loot + "\\menu_img\\");

            }else
            {
                pictureBox1.Image.Save(loot + "\\menu_img\\"+pic+".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        private void button2_Click(object sender, EventArgs e) //등록버튼 클릭시 이벤트
        {
            dbConnect db = new dbConnect();

            string[] menuType_Combobox = { "면류", "디저트", "밥류", "음료류", "카페" };
            int[] menuType = { 0, 0, 0, 0, 0 };
            //int noodle = 0, dessert = 0, food = 0, drink = 0, cafe = 0;

            for (int i = 0; i < 5; i++)
            {
                if (comboBox1.SelectedItem.ToString() == menuType_Combobox[i])
                {
                    menuType[i] = 1;
                    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text), menuType[0], menuType[1], menuType[2], menuType[3], menuType[4]);
                    Close();
                    break;
                }
            }
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #region 등록버튼클릭 이벤트 수정전
        //if (comboBox1.SelectedItem.ToString() == "면류") //가능하면 배열로 고칠 것
        //{
        //    noodle = 1;
        //    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text),noodle, dessert, food, drink, cafe);
        //    Close();
        //}

        //else if (comboBox1.SelectedItem.ToString() == "디저트")
        //{
        //    dessert = 1;
        //    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text), noodle, dessert, food, drink, cafe);
        //    Close();
        //}

        //else if (comboBox1.SelectedItem.ToString() == "밥류")
        //{
        //    food = 1;
        //    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text), noodle, dessert, food, drink, cafe);
        //    Close();
        //}
        //else if (comboBox1.SelectedItem.ToString() == "음료류")
        //{
        //    drink = 1;
        //    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text), noodle, dessert, food, drink, cafe);
        //    Close();
        //}
        //else if (comboBox1.SelectedItem.ToString() == "카페")
        //{
        //    cafe = 1;
        //    db.orderDBInsert(name_textbox.Text, Convert.ToInt32(price_textbox.Text), noodle, dessert, food, drink, cafe);
        //    Close();
        //}
        #endregion

        private void button3_Click(object sender, EventArgs e) //취소 버튼
        {
            Close();
        }
    }
}
