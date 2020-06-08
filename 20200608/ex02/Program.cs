using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        /*
         * 차량 관리 프로그램 v1.0
         * 
         * main() 에서 배열 초기화 / 랜덤
         * name = {"홍길동","김길동","박길동","이길동","최길동"}
         * tel = {"010-1111-1111","010-2222-2222","010-3333-3333","010-1235-1235","010-5555-5555"}
         * address = {"대구 동구 신암1동","서울 동구 신암1동","부산 동구 신암1동","대전 동구 신암1동","광주 동구 신암1동"} 
         * model = {"SM6","소나타","싼타페","K7","그랜저"}
         * color = {"블랙","실버","화이트","레드","블루"}
         * year = {2017,2018,2019,2020,2021}
         * company = {"삼성르노","현대","기아","쌍용"}
         * 
         * 고객정보를 10개 생성
        */
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-1235-1235", "010-5555-5555" };
            string[] address = { "대구 동구 신암1동", "서울 동구 신암1동", "부산 동구 신암1동", "대전 동구 신암1동", "광주 동구 신암1동" };
            string[] model = { "S M 6", "소나타", "싼타페", " K 7 ", "그랜저" };
            string[] color = { "블랙", "실버", "화이트", "레드", "블루" };
            int[] year = { 2017, 2018, 2019, 2020, 2021 };
            string[] company = { "삼성르노", "현대", "기아", "쌍용" };

            Customer[] cust = new Customer[10];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < cust.Length; i++)
            {
                cust[i] = new Customer(
                    name[rand.Next(0, 5)], tel[rand.Next(0, 5)], address[rand.Next(0, 5)],
                    model[rand.Next(0, 5)], color[rand.Next(0, 5)], year[rand.Next(0, 5)], company[rand.Next(0, 4)]);
            }

            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine("{0,2}) ", i + 1);
                cust[i].custShow();
            }
        }
    }
}
