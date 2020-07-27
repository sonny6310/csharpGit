using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//장바구니 메뉴이름, 가격, 수량 리스트 저장
namespace PcrommV2
{
    public class Cartdata
    {
        private string menu_name;
        private int menu_price;
        private int menu_count;
        public Cartdata(string menu_name, int menu_price, int menu_count)
        {
            this.menu_name = menu_name;
            this.menu_price = menu_price;
            this.menu_count = menu_count;
        }
        public string Menu_name { get { return menu_name; } set { menu_name = value; } }
        public int Menu_price { get { return menu_price; } set { menu_price = value; } }
        public int Menu_count { get { return menu_count; } set { menu_count = value; } }
    }
}
