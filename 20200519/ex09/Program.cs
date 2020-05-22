using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
