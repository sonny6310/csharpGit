using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 피라미드.
            int num = 5;
            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine(Environment.NewLine);

            // 수 입력받고 최대최소.
            Console.WriteLine("숫자 5개를 입력하시오");
            int[] intArr = new int[5];
            for(int i=0; i<5; i++)
            {
                Console.Write($"{i + 1}번째 숫자: ");
                intArr[i] = int.Parse(Console.ReadLine());
            }
            int max=int.MinValue;
            int min=int.MaxValue;
            for(int i=0; i<intArr.Length; i++)
            {
                for (int idx = 0; idx < intArr.Length; idx++)
                {
                    if (min > intArr[idx])
                    {
                        min = intArr[idx];
                    }
                    if (max < intArr[idx])
                    {
                        max = intArr[idx];
                    }
                }
            }
            Console.WriteLine($"최소는 {min}, 최대는 {max}");

            Console.WriteLine(Environment.NewLine);

            // 개미수열 20번째 숫자가 무엇인지 프로그램하기.
            string antseq = "1";
            for (int n = 1; n < 21; n++)
            {
                Console.WriteLine($"{n}번째 수열은 {antseq}");
                char ant = antseq[0];
                int count = 0;
                string temp="";
                for (int i = 0; i < antseq.Length; i++)
                {
                    if (ant == antseq[i])
                    {
                        count++;
                    }
                    else
                    {
                        temp = temp + ant + count;
                        count = 0;
                        ant = antseq[i];
                        count++;
                    }
                }
                temp = temp + ant + count;
                antseq = temp;
            }
        }
    }
}