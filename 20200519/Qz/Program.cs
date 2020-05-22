using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cm로 변환할 inch 입력: ");
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine($"{inch}inch = {cm}cm");

            Console.WriteLine(Environment.NewLine);

            Console.Write("pound로 변환할 kg 입력: ");
            double kg = double.Parse(Console.ReadLine());
            double pound = kg * 2.20462262;
            Console.WriteLine($"{kg}kg = {pound}pound");

            Console.WriteLine(Environment.NewLine);

            Console.Write("원의 반지름 입력: ");
            double r = double.Parse(Console.ReadLine());
            double L = 2 * Math.PI * r;
            double A = Math.PI * r * r;
            Console.WriteLine($"원의 둘레는 {L.ToString("0.00")}, 넓이는 {A.ToString("0.00")}이다.");
        }
    }
}
