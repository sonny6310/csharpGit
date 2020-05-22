using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iter
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"합 : {sum}");


            //for (int i = '가'; i < '힣'; i++)
            //{
            //    Console.Write((char)i);
            //}

            string[] arr = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
