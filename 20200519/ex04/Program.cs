using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue = int.MaxValue;
            int integerValueMin = int.MinValue;
            long longValue = long.MaxValue;
            long longValueMin = long.MinValue;
            Console.WriteLine("intMAX = "+integerValue);
            Console.WriteLine("intMIN = "+integerValueMin);
            Console.WriteLine("longMAX = "+longValue);
            Console.WriteLine("longMIN = "+longValueMin);
            Console.WriteLine($"int:{sizeof(int)}");
            Console.WriteLine(string.Format("long:{0}",sizeof(long)));
            Console.WriteLine(string.Format("float:{0}{1}double:{2}",sizeof(float),Environment.NewLine, sizeof(double)));
            Console.WriteLine(string.Format("long:{0}",sizeof(long)));
            Console.WriteLine(123L);

        }
    }
}
