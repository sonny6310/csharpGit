using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRequest1
{
    class WebRequest2
    {
        // bin - Debug에 test.html 생성하고
        // test.html 내용을 저장 ↓
        //    <body>
        //<div>
        //    <strong><span id = "HomeDeviceName" > 레이저 프린터</span></strong>
        //    <strong>192.168.1.120<span id = "deviceIp" /></ strong >
        //</ div >

        //< div class="consumable-block-header">
        //    <h2 id = "black" > black </ h2 >
        //    < p class="percentage">0%</p>
        //    <p class="data"><span>ABCDEFG</span></p>
        //    <div class="color" style="border: solid 1px black">
        //        <strong class="2" id="level">2%</strong>
        //    </div>
        //</div>

        //<div>
        //    <p><span>상태</span><strong id = "status" > 알수없음 </ strong ></ p >
        //    < p >< span > 남은페이지 </ span >< strong id="remainPage">1000</strong></p>
        //    <p><span>일련번호</span><strong id = "serialNumber" > 1234567 </ strong ></ p >
        //    < p >< span > 인쇄 페이지수</span><strong id = "printCount" > 123 </ strong ></ p >

        //     </ div >
        // </ body >
        static string URL = "test.html";

        static void Main(string[] args)
        {
            // HtmlAgilityPack NuGet패키지 설치해야함
            var page = new HtmlAgilityPack.HtmlDocument();
            page.Load(URL, Encoding.Default);

            // / : <head>안, // : <body>안

            // div태그-클래스가 consumable-block-header 안에서 p태그-클래스가 data인 곳의 내용을 span을 제거하고 파싱  
            var data = page.DocumentNode.SelectNodes("//div[@class='consumable-block-header']")[0].SelectNodes("p[@class='data']//span").First().InnerHtml.Trim();
            Console.WriteLine("data: " + data);

            // strong태그-id가 status인 곳의 내용을 파싱
            var status = page.DocumentNode.SelectNodes("//strong[@id='status']").First().InnerHtml.Trim();
            Console.WriteLine("status: " + status);

            // strong태그-id가 remainPage인 곳의 내용을 파싱
            var remainPage = page.DocumentNode.SelectNodes("//strong[@id='remainPage']").First().InnerHtml.Trim();
            Console.WriteLine("remainPage: " + remainPage);

            // strong태그-id가 serialNumber인 곳의 내용을 파싱
            var serialNumber = page.DocumentNode.SelectNodes("//strong[@id='serialNumber']").First().InnerHtml.Trim();
            Console.WriteLine("serialNumber: " + serialNumber);

            // strong태그-id가 printCount인 곳의 내용을 파싱
            var printCount = page.DocumentNode.SelectNodes("//strong[@id='printCount']").First().InnerHtml.Trim();
            Console.WriteLine("printCount: " + printCount);


            //var cntNode = page.DocumentNode.SelectNodes("//div[@class='consumable-block-header']");
            var cntNode = page.DocumentNode.SelectNodes("//div");
            Console.WriteLine("node 수: " + cntNode.Count);

            for (int i = 0; i < 4; i++)
            {
                var temp = cntNode[i].InnerHtml.Trim();
                Console.WriteLine($"{i}번째 노드: {temp}");
            }
        }
    }
}
