using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Log
    {
        public static void printLog(string content)
        {
            DirectoryInfo di = new DirectoryInfo("Log");
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("Log\\log.txt", true))
            {
                string logContent = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {content}";
                writer.WriteLine(logContent);
            }
        }
    }
}
