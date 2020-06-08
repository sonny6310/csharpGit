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
            /*
             * main()에서 다음 학생정보의 배열 초기화 , 랜덤하게 생성하여 생성자 매개변수로 전달
             * { 홍길동,김길동,박길동,이길동,최길동 }
             * { 20,25,30,35,40 }
             * { 남,여 }
             * { 조선 두메산골1,2,3,4,5 }
             * 10명의 학생 정보 생성
             * 10번째 학생 정보를 변경 => 전우치, 240, 남, 조선 강원 두메산골 
            */
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] adress = { "조선 두메산골1", "조선 두메산골2", "조선 두메산골3", "조선 두메산골4", "조선 두메산골5" };

            Random rand = new Random(DateTime.Now.Millisecond);

            Student[] stu = new Student[10];
            for (int i = 0; i < stu.Length; i++)
            {
                Student temporaryStudent = new Student(name[rand.Next(0, 5)], age[rand.Next(0, 5)], gender[rand.Next(0, 2)], adress[rand.Next(0, 5)]);
                stu[i] = temporaryStudent;
            }

            stu[9].mName = "전우치";
            stu[9].mAge = 240;
            stu[9].mGender = '남';
            stu[9].mAdress = "조선 강원 두메산골";

            for (int i = 0; i < stu.Length; i++)
            {
                Console.Write("{0,2}) ", i + 1);
                stu[i].stShow();
            }
        }
    }
}
