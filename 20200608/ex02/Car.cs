using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Car
    {
        /*
         * Car 클래스 속성 - 외부에서 접근 차단 / 모델(문자열), 색상(문자열), 연식(int), 제조회사(문자열)
         * Car 클래스 getter,setter 추가
         * 모든 속성 정보 출력 메소드 추가
         * 생성자
        */
        private string model;
        private string color;
        private int year;
        private string company;
        public string mModel { get { return model; } set { model = value; } }
        public string mColor { get { return color; } set { color = value; } }
        public int mYear { get { return year; } set { year = value; } }
        public string mCompany { get { return company; } set { company = value; } }
        public Car()
        {

        }
        public void carShow()
        {
            Console.WriteLine($"    모델: {model} \t 색상: {color} \t 연식: {year} \t 제조회사: {company}");
        }
    }
}
