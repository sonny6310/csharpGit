using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 로또 프로그램 v1.0
            // 1. 1~45 랜덤 숫자 6개 획득
            // 2. 중복 체크

            Random rand = new Random();
            int[] lotto = new int[6];
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = rand.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if(lotto[i] == lotto[j])
                    {
                        i--;
                    }
                }
            }
            foreach (var item in lotto)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
