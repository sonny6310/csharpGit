using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
{
    //인스턴스변수
    class TestClass
    {
        public int Power(int x)
        {
            return x * x;
        }
        public int Multi(int x, int y)
        {
            return x * y;
        }
    }

    //클래스변수
    //class TestClass
    //{
    //    public static int Power(int x)
    //    {
    //        return x * x;
    //    }
    //    public static int Multi(int x, int y)
    //    {
    //        return x * y;
    //    }
    //}
}
