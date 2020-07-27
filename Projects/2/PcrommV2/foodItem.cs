using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// 출력 메뉴 
namespace PcrommV2
{
    public partial class foodItem : UserControl
    {

        public foodItem()
        {
            InitializeComponent();
        }
    
        static foodItem instance;
        public static foodItem getInstance() //싱글톤
        {
            if (instance == null)
            {
                instance = new foodItem();
            }
            return instance;
        }
        public void initFoodInfo(string menuName, int menuPrice)
        {
            string loot = Application.StartupPath.ToString(); //어플리케이션 실행 폴더 추출
            menuNameL.Text = menuName;
            menuPriceL.Text = Convert.ToString(menuPrice);
            //픽쳐박스에 이미지 삽입
            //조건 - 메뉴이름.png 파일이 있는경우에만 이미지 보여줌.
            System.IO.FileInfo fi = new System.IO.FileInfo(loot + "\\menu_img\\" + menuName + ".png");
            if (fi.Exists)
            {
                pictureBox1.Load(@loot + "\\menu_img\\" + menuName + ".png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Load(@loot + "\\menu_img\\noimg.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("클릭");
            OrderItem.getInstance().Refresh();
            string name = menuNameL.Text;
            int price;

            //중복체크
            for (int i = 0; i < MainForm.getInstance().cart_data_list.Count; i++)
            {

                if (name == MainForm.getInstance().cart_data_list[i].Menu_name) //중복 
                {
                    MainForm.getInstance().cart_data_list[i].Menu_count++;
                    MainForm.list[i].setNum(MainForm.getInstance().cart_data_list[i].Menu_count);
                    MainForm.getInstance().reAllPrice();
                    goto jump;
                }
                else
                {
                }

            }
            price = Convert.ToInt32(menuPriceL.Text);
            Cartdata cd = new Cartdata(name, price, 1);
            MainForm.getInstance().initPriceList(cd);
            jump:;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderItem.getInstance().Refresh();
            string name = menuNameL.Text;
            int price;
            //중복체크
            for (int i = 0; i < MainForm.getInstance().cart_data_list.Count; i++)
            {
                if (name == MainForm.getInstance().cart_data_list[i].Menu_name) //중복 
                {
                    MainForm.getInstance().cart_data_list[i].Menu_count++;
                    MainForm.list[i].setNum(MainForm.getInstance().cart_data_list[i].Menu_count);
                    MainForm.getInstance().reAllPrice();
                    goto jump;
                }
                else
                {
                }
            }
            price = Convert.ToInt32(menuPriceL.Text);
            Cartdata cd = new Cartdata(name, price, 1);
            MainForm.getInstance().initPriceList(cd);
            jump:;
        }
    }
}
