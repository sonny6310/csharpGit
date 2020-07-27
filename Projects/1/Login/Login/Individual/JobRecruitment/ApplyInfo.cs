using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Individual.JobRecruitment
{
      class ApplyInfo
      {
            private int infownum;
            private string ComName;
            private string infoField;
            private int infoPay;
            private string infoPlace;

            public int get_wnum { get { return infownum; } set { infownum = value; } }
            public string get_Cname{ get { return ComName; } set { ComName = value; } }
            public string get_Cfield { get { return infoField; } set { infoField = value; } }
            public int get_Cpay{ get { return infoPay; } set { infoPay = value; } }
            public string get_Cplace { get { return infoPlace; } set { infoPlace = value; } }

      }
}
