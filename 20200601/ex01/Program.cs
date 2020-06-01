using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coin = new int[4]; 
            int[] arr = { 500, 100, 50, 10 };
            int won;
            Console.Write("교환할 금액을 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out won);
            int output = won;

            for(int i=0; i<arr.Length; i++)
            {
                coin[i] = output / arr[i];
                output = output % arr[i];
            }

            Console.WriteLine("---------------------------" + Environment.NewLine + "  동전 교환 프로그램 v1.0" + Environment.NewLine + "---------------------------");
            Console.WriteLine($"오백원 개수 : {coin[0]}개");
            Console.WriteLine($"백원 개수 : {coin[1]}개");
            Console.WriteLine($"오십원 개수 : {coin[2]}개");
            Console.WriteLine($"십원 개수 : {coin[3]}개");
            Console.WriteLine($"바꾸지 못한 잔돈 : {output}원");
            Console.WriteLine("---------------------------");
        }
    }
}
