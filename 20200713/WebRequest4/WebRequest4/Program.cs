using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq; // Newtonsoft.Json NuGet패키지 설치
using System.Net;
using System.IO;

namespace WebRequest4
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://developers.naver.com/docs/common/openapiguide/
            //https://developers.naver.com/docs/search/cafearticle/

            //string text = "맛집";
            //string sta = "1";
            //string url = "https://openapi.naver.com/v1/search/cafearticle.json?query=" + text + "&display=100&start=" + sta + "&sort=sim"; // 한번에 display 최대 100개, start(시작위치) 최대 1000까지밖에 못함(네이버에서 부하방지하려고 막음).
            //string clientId = "k0T8VWZqud87MU9Sv9t7";
            //string clientSecret = "fJYqjnrXxL";

            //string responseJson = GetRequestResult(url, clientId, clientSecret);
            //// json 객체 파싱
            //var parseJson = JObject.Parse(responseJson);

            //Console.WriteLine("검색내용: " + text);
            //// 검색 결과 display 개수
            //var queryResultCount = Convert.ToInt32(parseJson["display"]);
            //Console.WriteLine("검색결과 화면 출력 개수: " + queryResultCount);
            //// 총 검색 결과
            //var totalResultCount = Convert.ToInt32(parseJson["total"]);
            //Console.WriteLine("총 검색 결과 수: " + totalResultCount + Environment.NewLine);

            ////for (int i = 0; i < queryResultCount; i++)
            ////{
            ////    Console.WriteLine($"{i+1})");
            ////    var title = parseJson["items"][i]["title"].ToString();
            ////    Console.WriteLine("제목: " + title);
            ////    var description = parseJson["items"][i]["description"].ToString();
            ////    Console.WriteLine("요약정보: " + description);
            ////    var cafeName = parseJson["items"][i]["cafename"].ToString();
            ////    Console.WriteLine("카페명: " + cafeName);
            ////    var cafeUrl = parseJson["items"][i]["cafeurl"].ToString();
            ////    Console.WriteLine("카페URL: " + cafeUrl);
            ////    Console.WriteLine();
            ////}

            //int count = 1;
            //while (true)
            //{
            //    for (int i = 0; i < queryResultCount; i++)
            //    {
            //        Console.WriteLine($"{count++})");
            //        var title = parseJson["items"][i]["title"].ToString();
            //        Console.WriteLine("제목: " + title);
            //        var description = parseJson["items"][i]["description"].ToString();
            //        Console.WriteLine("요약정보: " + description);
            //        var cafeName = parseJson["items"][i]["cafename"].ToString();
            //        Console.WriteLine("카페명: " + cafeName);
            //        var cafeUrl = parseJson["items"][i]["cafeurl"].ToString();
            //        Console.WriteLine("카페URL: " + cafeUrl);
            //        Console.WriteLine();
            //    }
            //    if ((Convert.ToInt32(sta) + queryResultCount) > 1000)
            //    {
            //        sta = "1000";
            //        url = "https://openapi.naver.com/v1/search/cafearticle.json?query=" + text + "&display=100&start=" + sta + "&sort=sim";
            //        responseJson = GetRequestResult(url, clientId, clientSecret);
            //        parseJson = JObject.Parse(responseJson);
            //        for (int i = 1; i < queryResultCount; i++)
            //        {
            //            Console.WriteLine($"{count++})");
            //            var title = parseJson["items"][i]["title"].ToString();
            //            Console.WriteLine("제목: " + title);
            //            var description = parseJson["items"][i]["description"].ToString();
            //            Console.WriteLine("요약정보: " + description);
            //            var cafeName = parseJson["items"][i]["cafename"].ToString();
            //            Console.WriteLine("카페명: " + cafeName);
            //            var cafeUrl = parseJson["items"][i]["cafeurl"].ToString();
            //            Console.WriteLine("카페URL: " + cafeUrl);
            //            Console.WriteLine();
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        sta = (Convert.ToInt32(sta) + Convert.ToInt32(queryResultCount)).ToString();
            //        url = "https://openapi.naver.com/v1/search/cafearticle.json?query=" + text + "&display=100&start=" + sta + "&sort=sim";
            //        responseJson = GetRequestResult(url, clientId, clientSecret);
            //        parseJson = JObject.Parse(responseJson);
            //    }
            //}

            for (int i = 0; i < 11; i++)
            {
                if (i == 9)
                {
                    displayResult("맛집", 99, (100 * i) + 1);
                }
                else if (i == 10)
                {
                    displayResult("맛집", 100, 100 * i);
                }
                else
                {
                    displayResult("맛집", 100, (100*i)+1);
                }
            }
        }

        // 데이터를 가져옴
        static string GetRequestResult(string openApi, string clientId, string clientSecret)
        {
            var requestResult = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(openApi);
                // request 정보에 id, secret key 정보를 같이 전송
                request.Headers.Add("X-Naver-Client-Id", clientId);
                request.Headers.Add("X-Naver-Client-Secret", clientSecret);

                // request에 대한 응답 처리 및 데이터 처리
                Stream dataStream = null;
                var response = request.GetResponse();
                dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                requestResult = reader.ReadToEnd();

                // 자원 해제
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return requestResult;
        }
        private static int count = 1;
        static void displayResult(string word, int display, int start)
        {
            string url = string.Format("https://openapi.naver.com/v1/search/cafearticle.json?query={0}&display={1}&start={2}&sort=sim", word, display, start); // 한번에 display 최대 100개, start(시작위치) 최대 1000까지밖에 못함(네이버에서 부하방지하려고 막음).
            string clientId = "k0T8VWZqud87MU9Sv9t7";
            string clientSecret = "fJYqjnrXxL";

            string responseJson = GetRequestResult(url, clientId, clientSecret);
            // json 객체 파싱
            var parseJson = JObject.Parse(responseJson);

            Console.WriteLine("검색내용: " + word);
            // 검색 결과 display 개수
            var queryResultCount = display;
            Console.WriteLine("검색결과 화면 출력 개수: " + queryResultCount);
            // 총 검색 결과
            var totalResultCount = Convert.ToInt32(parseJson["total"]);
            Console.WriteLine("총 검색 결과 수: " + totalResultCount + Environment.NewLine);

            for (int i = 0; i < queryResultCount; i++)
            {
                Console.WriteLine($"{count++})");
                var title = parseJson["items"][i]["title"].ToString();
                Console.WriteLine("제목: " + title);
                var description = parseJson["items"][i]["description"].ToString();
                Console.WriteLine("요약정보: " + description);
                var cafeName = parseJson["items"][i]["cafename"].ToString();
                Console.WriteLine("카페명: " + cafeName);
                var cafeUrl = parseJson["items"][i]["cafeurl"].ToString();
                Console.WriteLine("카페URL: " + cafeUrl);
                Console.WriteLine();
            }
        }
    }
}
