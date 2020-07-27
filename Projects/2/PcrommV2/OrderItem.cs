using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcrommV2
{
    public partial class OrderItem : UserControl
    {
        // 수량 감소, 증가
        public int count = 1;
        static OrderItem instance;
        public OrderItem()
        {
            InitializeComponent();
        }
        public static OrderItem getInstance() //싱글톤
        {
            if (instance == null)
            {
                instance = new OrderItem();
            }
            return instance;
        }
        public void getItem(string name, int price, int count) // 메뉴 이름 ,가격  ,수량 리스트 가져오기 
        {
            labelFdName.Text = name;
            labelPrice.Text = Convert.ToString(price);
            labelCount.Text = Convert.ToString(count);
        }

        private void btnDelete_Click_1(object sender, EventArgs e) //메뉴 삭제 
        {

            int del = Convert.ToInt32(labelPrice.Text);
            MainForm.getInstance().Allprice -= Convert.ToInt32(del * count);
            panel1.Controls.Remove(panel1);

            for (int i = 0; i < MainForm.getInstance().cart_data_list.Count; i++)
            {
                if (MainForm.getInstance().cart_data_list[i].Menu_name == labelFdName.Text)
                {
                    MainForm.getInstance().cart_data_list.Remove(MainForm.getInstance().cart_data_list[i]);
                    MainForm.list.Remove(MainForm.list[i]);
                }
            }
            Dispose();
            MainForm.getInstance().reAllPrice();
        }
        public void setNum(int count)
        {
            labelCount.Text = count.ToString();

        }
        public void button2_Click(object sender, EventArgs e) // 수량 증가 
        {
            for (int i = 0; i < MainForm.getInstance().cart_data_list.Count; i++)
            {
                if (MainForm.getInstance().cart_data_list[i].Menu_name == labelFdName.Text)
                {
                    MainForm.getInstance().cart_data_list[i].Menu_count++;

                }
                MainForm.list[i].setNum(MainForm.getInstance().cart_data_list[i].Menu_count);
            }
            MainForm.getInstance().Allprice += Convert.ToInt32(labelPrice.Text);
            MainForm.getInstance().addCartPriceL();
        }

        private void button1_Click(object sender, EventArgs e) // 수량 감소 
        {

            for (int i = 0; i < MainForm.getInstance().cart_data_list.Count; i++)
            {
                if (MainForm.getInstance().cart_data_list[i].Menu_name == labelFdName.Text)
                {
                    if (MainForm.getInstance().cart_data_list[i].Menu_count < 1)
                    {
                        MessageBox.Show("주문수량이 1 미만입니다.");
                        return;
                    }
                    MainForm.getInstance().cart_data_list[i].Menu_count--;
                }
                MainForm.list[i].setNum(MainForm.getInstance().cart_data_list[i].Menu_count);
            }
            MainForm.getInstance().Allprice -= Convert.ToInt32(labelPrice.Text);
            MainForm.getInstance().addCartPriceL();
        }
    }
}
