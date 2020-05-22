using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0: Console.WriteLine("원숭이 띠입니다."); break;
                case 1: Console.WriteLine("닭 띠입니다."); break;
                case 2: Console.WriteLine("개 띠입니다."); break;
                case 3: Console.WriteLine("돼지 띠입니다."); break;
                case 4: Console.WriteLine("쥐 띠입니다."); break;
                case 5: Console.WriteLine("소 띠입니다."); break;
                case 6: Console.WriteLine("호랑이 띠입니다."); break;
                case 7: Console.WriteLine("토끼 띠입니다."); break;
                case 8: Console.WriteLine("용 띠입니다."); break;
                case 9: Console.WriteLine("뱀 띠입니다."); break;
                case 10: Console.WriteLine("말 띠입니다."); break;
                case 11: Console.WriteLine("양 띠입니다."); break;
            }

            //int month = int.Parse(Console.ReadLine());
            int month = DateTime.Now.Month;
            if (month >= 3 && month <= 5)
            {
                if (month == 5)
                {
                    Console.WriteLine("5월은 가정의 달입니다.");
                }
                Console.WriteLine("봄입니다.");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine("여름입니다.");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine("가을입니다.");
            }
            else
            {
                Console.WriteLine("겨울입니다.");
            }


            Console.Write("숫자입력: ");
            int input = int.Parse(Console.ReadLine());
            if(input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
