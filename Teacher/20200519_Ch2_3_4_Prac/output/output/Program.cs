using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int:{sizeof(int)}");
            Console.WriteLine(string.Format("long:{0}", sizeof(long)));

            Console.WriteLine(string.Format("float:{0}{1}double:{2}", 
                sizeof(float), Environment.NewLine, sizeof(double)));

            Console.WriteLine("char : " + sizeof(char));

            Console.WriteLine(123L); //long을 명시해줌

            //unsigned 자료형은 음수가 없음
            uint unsignedInt = uint.MaxValue;
            ulong unsignedLong = ulong.MaxValue;
            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

            int integerValue = int.MaxValue;
            Console.WriteLine((long)integerValue+1);
            long longValue = long.MaxValue;
            Console.WriteLine(longValue);
            integerValue = int.MinValue;
            Console.WriteLine(integerValue);
            longValue = long.MinValue;
            Console.WriteLine(longValue);


            bool test = true ^ false;
            Console.WriteLine(test);
            
            if(!((1 + 2) > (3 + 2)))
            {
                Console.WriteLine("안 따라 치셔도 됨");
            }
        }
    }
}
