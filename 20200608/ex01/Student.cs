using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Student
    {
        /*
         * 외부에서 접근차단 인스턴스 속성 : 이름(string),나이(int),성별(char),주소(string)
         * 매개변수사용하는 생성자
         * getter, setter
         * 모든 속성 정보 출력 인스턴스메소드 추가
        */
        private string name;
        private int age;
        private char gender;
        private string adress;
        public string mName { get { return name; } set { name = value; } }
        public int mAge { get { return age; } set { age = value; } }
        public char mGender { get { return gender; } set { gender = value; } }
        public string mAdress { get { return adress; } set { adress = value; } }

        public Student(string name, int age, char gender, string adress)
        {
            mName = name;
            mAge = age;
            mGender = gender;
            mAdress = adress;
        }

        public void stShow()
        {
            Console.WriteLine($"이름: {name}\t나이: {age}\t성별: {gender}\t주소: {adress}");
        }
    }
}
