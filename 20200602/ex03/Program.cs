using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.carShowInfo();

            c.mManuf = "현대";
            c.mColor = "그레이";
            c.mModel = "그랜져";
            c.mPrice = "오천만원";
            c.carShowInfo();

            Car cc = new Car("삼성", "화이트", "SM7", "삼천만원");
            cc.carShowInfo();
        }
    }
}
