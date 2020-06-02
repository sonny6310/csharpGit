using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Car
    {
        const string agencyName = "동대구 영업소";
        private string manuf;
        private string color;
        private string price;
        private string model;

        public string mManuf
        {
            get
            {
                return manuf;
            }
            set
            {
                manuf = value;
            }
        }

        public string mColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string mPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string mModel
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public Car()
        {
            manuf = "기아";
            color = "블랙";
            model = "K7";
            price = "사천만원";
        }

        public Car(string manuf, string color, string price, string model)
        {
            mManuf = manuf;
            mColor = color;
            mPrice = price;
            mModel = model;
        }

        public void carShowInfo()
        {
            Console.WriteLine($"제조사 - {manuf}");
            Console.WriteLine($"색상 - {color}");
            Console.WriteLine($"이름 - {model}");
            Console.WriteLine($"가격 - {price}");
            Console.WriteLine($"대리점명 - {agencyName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.carShowInfo();

            Console.WriteLine(Environment.NewLine + "------------------------" + Environment.NewLine);

            c.mManuf = "현대";
            c.mColor = "그레이";
            c.mModel = "그랜져";
            c.mPrice = "오천만원";
            c.carShowInfo();

            Console.WriteLine(Environment.NewLine + "------------------------" + Environment.NewLine);

            Car cc = new Car("삼성", "화이트", "SM7", "삼천만원");
            cc.carShowInfo();
        }
    }
}
