using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRand
{
    class RandData
    {
        static Random rand = new Random();

        static string[] first = { "김", "강", "견", "고", "공", "구", "권", "기", "나", "남", "노", "류", "문", "모", "박", "방", "배", "봉", "석", "손", "설", "송", "안", "오", "원", "유", "이", "임", "장", "전", "조", "천", "최", "팽", "하", "한", "허" };
        static string[] name = { "길", "세", "나", "민", "연", "지", "하", "윤", "채", "은", "수", "예", "서", "준", "도", "시", "우", "주", "권", "원", "호", "현", "우", "재", "건", "선", "승", "후", "태", "찬", "나", "율", "다", "인", "아" };
        static string[] alpha = { "가", "나", "다", "라", "마", "바", "사", "아", "자", "차", "카", "타", "파", "하", "거", "너", "더", "러", "머", "버", "서", "어", "저", "처", "커", "터", "퍼", "허", "고", "노", "도", "로", "모", "보", "소", "오", "조", "초", "코", "토", "포", "호", "구", "누", "두", "루", "무", "부", "수", "우", "주", "추", "쿠", "투", "푸", "후", "기", "니", "디", "리", "미", "비", "시", "이", "지", "치", "키", "티", "피", "히" };


        public static string getName()
        {
            string fullName = first[rand.Next(0, first.Length)] + name[rand.Next(0, name.Length)] + name[rand.Next(0, name.Length)];
            return fullName;
        }

        public static int getMem_num()
        {
            int Mem = rand.Next(1, 8);
            return Mem;
        }

        public static string getCar()
        {
            string car = rand.Next(1, 100) + alpha[rand.Next(0,name.Length)] + rand.Next(1000, 10000);
            return car;
        }

        public static int getPet()
        {
            int pet = rand.Next(0, 2);
            return pet;
        }

        public static int getbaby()
        {
            int baby = rand.Next(0, 2);
            return baby;
        }

        public static string getphone()
        {
            string ph = "010-" + rand.Next(1000, 10000)+"-"+rand.Next(1000, 10000);
            return ph;
        }

    }
}
