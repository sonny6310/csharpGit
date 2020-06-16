using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_oracleConn
{
    class RandData
    {
        static Random rand = new Random();

        static string[] first = { "김", "이", "박", "최", "정", "강", "조", "윤", "장", "임", "한", "홍" };
        static string[] middle = { "길", "세", "나", "민", "연", "지", "하", "윤", "채", "은", "수", "예" };
        static string[] last = { "동", "아", "경", "수", "호", "율", "아", "나", "희", "후", "훈", "진" };
        static string[] randAddr = { "서울", "부산", "인천", "대구", "대전", "광주", "울산", "수원", "성남", "전주", "천안", "제주" };
        static string[] randAddrGuu = { "서구", "중구", "북구", "남구", "동구" };
        static string[] randAddrDong = { "1동", "2동", "3동", "4동", "5동" };
        public static string getName()
        {
            string fullName = first[rand.Next(0, 12)] + middle[rand.Next(0, 12)] + last[rand.Next(0, 12)];
            return fullName;
        }

        public static int getAge()
        {
            int age = rand.Next(1, 100);
            return age;
        }

        public static string getAddr()
        {
            string addr = randAddr[rand.Next(0, 12)] + " " + randAddrGuu[rand.Next(0, 5)] + " " + randAddrDong[rand.Next(0, 5)];
            return addr;
        }
    }
}
