using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class User
    {
        public static double PI = 3.141592;
        public DateTime regDate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.regDate = DateTime.Now;
            Console.WriteLine(user.regDate); // 인스턴스변수
            Console.WriteLine($"PI = {User.PI}"); // 클래스변수
            
        }
    }
}
