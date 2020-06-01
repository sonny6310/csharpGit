using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = { 1, 20, 300, 4000, 50000 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                string str = string.Format("배열[{0}] : {1,5}",i,arrInt[i]);  // {0}에 i값, {1}에 arrInt[i]값을 오른쪽정렬5
                Console.WriteLine(str);
            }

            Console.WriteLine();

            char[] arrCh = new char[6] { '이', '박', '김', '홍', '최', '채' }; // C에서 char는 1바이트. c#은 2바이트 : 한글(2바이트)가 처리됨
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.WriteLine($"배열[{i}] : {arrCh[i]}");
            }

            Console.WriteLine();

            Random rand = new Random();
            string[] name = { "ㄱㄱㄱ", "ㄴㄴㄴ", "ㄷㄷㄷ", "ㄹㄹㄹ" };
            for (int i = 0; i < name.Length; i++)
            {
                int r = rand.Next(0, 4);
                Console.WriteLine($"배열[{r}] : {name[r]}");
            }

            Console.WriteLine();

            // 기본 배열 (가변x, 사각형의 형태로 유지되어야, 수 바로 입력 가능)
            int[,] arr2Int = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // arr2Int.Length 출력하면 8.
            for (int i = 0; i < arr2Int.GetLength(0); i++)
            {
                for (int j = 0; j < arr2Int.GetLength(1); j++)
                {
                    Console.Write("{0, -10}",arr2Int[i,j]); // 왼쪽정렬 10
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 가변배열 (한 행씩 new 배열 선언하여 차원배열을 입력)
            string[][] arrStr = new string[3][];
            arrStr[0] = new string[] { "ㄱㄱㄱ", "ㄴㄴㄴ", "ㄷㄷㄷ" };
            arrStr[1] = new string[] { "ㄹㄹㄹ" };
            arrStr[2] = new string[] { "ㅁㅁㅁ", "ㅂㅂㅂ" };

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < arrStr[i].Length; j++)
                {
                    Console.Write("{0, -10}", arrStr[i][j]); // 왼쪽정렬 10
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[] arrEach = { 10, 20, 30, 40 };
            foreach (var item in arrEach)
            {
                Console.Write("{0, -5}", item);
            }

            Console.WriteLine(Environment.NewLine);

            int[,] arr2Each = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            foreach (var item in arr2Each)
            {
                Console.Write(item + " ");
            }
        }
    }
}
