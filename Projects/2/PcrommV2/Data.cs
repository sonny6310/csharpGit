using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcrommV2
{
    class Data
    {
        static Data instance;
        public static Data getinstance()
        {
            if (instance == null)
            {
                instance = new Data();
            }
            return instance;
        }
        string pcName = "pc이름 지정안됨";
        string upConn;
        public string conn(string upConn, string upClog, string upID, string upPw)
        {
            this.upConn = "Data Source=" + upConn + ";Initial Catalog=" + upClog + ";User ID=" + upID + "; Password =" + upPw;
            return upConn;
        }
        public string UpConn { get { return upConn; } set { upConn = value; } }
        public string PcName { get { return pcName; } set { pcName = value; } }
    }
}
