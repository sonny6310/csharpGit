using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace WebRequest
{
    class WebRequest3
    {
        static void Main(string[] args)
        {
            Uri URL = new Uri("https://www.youtube.com/watch?v=FqK7lI6zuL4");
            HttpWebRequest request = HttpWebRequest.Create(URL) as HttpWebRequest;

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            using (Stream responseStream = response.GetResponseStream())
            {
                HtmlDocument s = new HtmlDocument();
                Encoding targetEncoding = Encoding.UTF8;
                s.Load(responseStream, targetEncoding, true);
                IXPathNavigable nav = s;
                string title = WebUtility.HtmlDecode(nav.CreateNavigator().SelectSingleNode("/html/head/meta[@property='og:title']/@content").ToString());
                Console.WriteLine("제목: " + title);
                string description = WebUtility.HtmlDecode(nav.CreateNavigator().SelectSingleNode("/html/head/meta[@property='og:description']/@content").ToString());
                Console.WriteLine("정보: " + description);
                string url = WebUtility.HtmlDecode(nav.CreateNavigator().SelectSingleNode("/html/head/meta[@property='og:url']/@content").ToString());
                Console.WriteLine("URL: " + url);
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
