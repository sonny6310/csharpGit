using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Student
    {
        private string name;
        private int age;
        public static string ID = "1111";

        // c# get,set
        public string mName
        {
            get { return name; }
            set { name = value; }
        }

        public int mAge
        {
            get { return age; }
            set { age = value; }
        }

        // 생성자 : 객체 지향 프로그래밍에서 객체의 초기화를 담당. 객체가 처음 생성될 때 1번만 호출되어 멤버 변수를 초기화하고, 필요에 따라 자원을 할당
        public Student(string name, int age)
        {
            mName = name;
            mAge = age;
        }

        public Student()
        {
            // 오버로딩
        }

        ~Student()
        {
            Console.WriteLine("--------");
            Console.WriteLine(" 소멸자 ");
            Console.WriteLine("--------");
        }

        public void stShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}");
            Console.WriteLine($"ID : {ID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Student("홍길동", 50).stShowInfo();

            Student stu = new Student();
            stu.mName = "ㄱㄴㄷㄹ";
            stu.mAge = 25;
            Console.WriteLine("--------------------");
            stu.stShowInfo();

            Console.WriteLine("--------------------");
            Console.WriteLine($"ID : {Student.ID}");
        }
    }
}
