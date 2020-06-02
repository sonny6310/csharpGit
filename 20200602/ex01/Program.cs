using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Person
    {
        private string name;
        private int age;
        // setter
        public void setName(string name)
        {
            this.name = name;
        }
        // getter
        public string getName()
        {
            return name;
        }
        // call by value
        public void swapNum(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        // call by reference
        public void swapNumRef(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        // 출력 매개변수 out 문법
        public void add(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
        }
        // 오버로딩
        // num2와 num3에 =0으로 선언해놓음으로써 p.add(10) => num1=10, num2=0, num3=0 으로 입력되고 p.add(10,20) => num1=10, num2=20, num3=0이 입력된다.
        // p.add(10,20,30) => 알고있던 대로 num1=10, num2=20, num3=30이 입력된다.
        public int add(int num1, int num2=0, int num3=0)
        {
            return num1 + num2 + num3;
        }      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            int num1 = 100;
            int num2 = 200;
            p.swapNum(num1, num2);
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            p.swapNumRef(ref num1, ref num2);
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");

            int res=0;
            p.add(100, 200, out res);
            Console.WriteLine($"res = {res}");

            Console.WriteLine(p.add(10, 20, 30));
            Console.WriteLine(p.add(10, 20));
            Console.WriteLine(p.add(10));
        }
    }
}
