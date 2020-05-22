using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
}
class Program
{
    static void Zodiac(int input)
    {
        if (input % 12 == 0)
        {
            Console.Write("잔나비띠");
        }
        else if (input % 12 == 1)
        {
            Console.Write("닭띠");
        }
        else if (input % 12 == 2)
        {
            Console.Write("개띠");
        }
        else if (input % 12 == 3)
        {
            Console.Write("돼지띠");
        }
        else if (input % 12 == 4)
        {
            Console.Write("쥐띠");
        }
        else if (input % 12 == 5)
        {
            Console.Write("소띠");
        }
        else if (input % 12 == 6)
        {
            Console.Write("범띠");
        }
        else if (input % 12 == 7)
        {
            Console.Write("토끼띠");
        }
        else if (input % 12 == 8)
        {
            Console.Write("용띠");
        }
        else if (input % 12 == 9)
        {
            Console.Write("뱀띠");
        }
        else if (input % 12 == 10)
        {
            Console.Write("말띠");
        }
        else
        {
            Console.Write("양띠");
        }
    }
    static void Season(int input2)
    {
        if (input2 % 12 >= 6 && input2 % 12 <= 8)
        {
            Console.Write("여름");
        }
        else if (input2 % 12 >= 0 && input2 % 12 <= 2)
        {
            Console.Write("겨울");
        }
        else if (input2 % 12 >= 3 && input2 % 12 <= 5)
        {
            Console.Write("봄");
        }
        else
        {
            Console.Write("가을");
        }
    }
    static void Main(string[] args)
    {
        int nowYear = DateTime.Now.Year;
        Console.Write("올 해 태어난 사람은 ");
        Zodiac(nowYear);
        Console.WriteLine("입니다.");
        int nowMonth = DateTime.Now.Month;
        Console.Write("현재는 ");
        Season(nowMonth);
        Console.WriteLine("입니다.");

        Console.WriteLine(Environment.NewLine);

        Console.Write("태어난 연도 입력: ");
        int myYear = int.Parse(Console.ReadLine());
        Console.Write($"{myYear}년에 태어난 사람은 ");
        Zodiac(myYear);
        Console.WriteLine("입니다.");

        Console.WriteLine(Environment.NewLine);
        
        Console.Write("달 입력: ");
        int myMonth = int.Parse(Console.ReadLine());
        Console.Write($"{myMonth}월은 ");
        Season(myMonth);
        Console.WriteLine("입니다.");
    }
}
