using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Customer
    {
        /*
         * Customer 클래스 속성 - 외부에서 접근 차단 / Car클래스 객체, 이름(문자열), 전화번호(문자열), 주소(문자열)
         * Customer 클래스 getter,setter 추가
         * 모든 속성 정보 출력 메소드 추가
         * 생성자
        */
        private Car car = new Car();
        private string name;
        private string tel;
        private string address;
        public string mName { get { return name; } set { name = value; } }
        public string mTel { get { return tel; } set { tel = value; } }
        public string mAdress { get { return address; } set { address = value; } }
        public Customer(string name, string tel, string adress, string model, string color, int year, string company)
        {
            mName = name;
            mTel = tel;
            mAdress = adress;
            car.mModel = model;
            car.mColor = color;
            car.mYear = year;
            car.mCompany = company;
        }
        public Customer()
        {

        }
        public void custShow()
        {
            Console.WriteLine($"    이름: {name} \t 전화번호: {tel} \t 주소: {address}");
            car.carShow();
            Console.WriteLine("    ----------------------------------------------------------------------------");
        }
    }
}
