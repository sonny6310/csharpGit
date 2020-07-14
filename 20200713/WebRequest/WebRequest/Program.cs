using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebRequest1
{
    class Program
    {
        static string URL = "https://movie.naver.com/movie/running/current.nhn";

        static void Main(string[] args)
        {
            // WebRequest 객체 생성
            WebRequest request = WebRequest.Create(URL);
            // 인증절차
            request.Credentials = CredentialCache.DefaultCredentials;

            // 서버응답처리
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("서버상태: " + response.StatusDescription);

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            // 데이터 읽기
            string fromServer = reader.ReadToEnd();
            // 데이터 출력
            Console.WriteLine(fromServer);
            // 자원 해제
            reader.Close();
            dataStream.Close();
            response.Close();


            // html소스코드 수집됨. 반정형데이터
        }
    }
}
