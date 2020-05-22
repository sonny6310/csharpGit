using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "abc";
            output += "defg";
            Console.WriteLine(output);

            Console.WriteLine(Environment.NewLine);

            int number = 100;
            Console.WriteLine(number.GetType());
            Console.WriteLine((123L).GetType());

            Console.WriteLine(Environment.NewLine);

            Console.Write("문장을 입력하시오: ");
            string input = Console.ReadLine();     // string타입으로 입력받음
            Console.WriteLine("입력한 문장 출력: " + input);

            Console.WriteLine(Environment.NewLine);

            string test1 = "1";
            int tester1 = int.Parse(test1);

            string test2 = "asvdrset";
            int tester2;
            int.TryParse(test2, out tester2);

            string test3 = "2";
            int tester3;
            int.TryParse(test3, out tester3);

            Console.WriteLine("tester1 = " + tester1);
            //Console.WriteLine("테스트 : " + int.Parse(test2));
            // TryParse가 아닌 그냥 int.Parse로 int형으로 바꿀 수 없는 것을 바꾸라고 했을 시 오류가 나며 멈춰버린다.
            Console.WriteLine("tester2 = {0}", tester2);   // int형으로 바꿀 수 없는 것을 int로 바꾸라고 했으므로 false의 의미인 0이 출력된다.
            Console.WriteLine(tester2.ToString() + " asdf");
            Console.WriteLine($"tester3 = {tester3}");

            Console.WriteLine(Environment.NewLine);

            double num = 51.3777;
            Console.WriteLine(num);
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));

            Console.WriteLine(Environment.NewLine);

            string nnn1 = num.ToString();  // 문자열로 변환하는 방법1
            string nnn2 = num + "";        // 문자열로 변환하는 방법2
            char ch = 'a';
            string mmm2 = ch.ToString();
            string mmm1 = ch + "";
        }
    }
}
