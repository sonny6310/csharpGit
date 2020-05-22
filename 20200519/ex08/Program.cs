using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            for(int i=1; i<101; i++)
            {
                output += i;
            }
            Console.WriteLine($"1부터 100까지 합은 {output} 입니다.");

            Console.WriteLine(Environment.NewLine);

            for (int i = '가'; i < '힣'; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
