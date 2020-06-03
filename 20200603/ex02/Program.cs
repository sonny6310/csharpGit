using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class SecretMap
    {
        public SecretMap(int n, int[] arr1, int[] arr2)
        {
            string[] mapArr = new string[n];
            string[] map = new string[n];

            for (int i = 0; i < n; i++)
            {
                mapArr[i] = Convert.ToString((arr1[i] | arr2[i]), 2);
                string input = "";
                for (int j = 0; j < mapArr[i].Length; j++)
                {

                    if ((mapArr[i])[j] == '1')
                    {
                        input += "#";
                    }
                    else
                    {
                        input += " ";
                    }
                    map[i] = input;
                }
            }
            Console.WriteLine("-------");
            Console.WriteLine("비밀지도");
            Console.WriteLine("-------");
            foreach (var item in map)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
        }
    }
      class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int[] arr1_1 = { 9, 20, 28, 18, 11 };
            int[] arr1_2 = { 30, 1, 21, 17, 28 };
            SecretMap sm1 = new SecretMap(n1,arr1_1,arr1_2);

            Console.WriteLine();

            int n2 = 6;
            int[] arr2_1 = { 46, 33, 33, 22, 31, 50 };
            int[] arr2_2 = { 27, 56, 19, 14, 14, 10 };
            SecretMap sm2 = new SecretMap(n2, arr2_1, arr2_2);
        }
    }
}
