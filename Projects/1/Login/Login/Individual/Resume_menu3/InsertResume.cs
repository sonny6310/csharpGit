using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Individual.Resume_menu3
{

    class InsertResume
    {
           
        private string resumeSubject;
        private string resumeLocation;
        private string resumeExp;
        private string resumeLicense;
        private string resumeContent;
        private string re_num;
        private string reName;
        private string reAddr;
        private string rePhone;
        private string reEmail;

        public string resume_name { get { return reName; } set { reName = value; } }
        public string resume_Addr { get { return reAddr; } set { reAddr = value; } }
        public string resume_Phone { get { return rePhone; }set { rePhone = value; } }
        public string resume_Email { get { return reEmail; } set { reEmail = value; } }
        public string resume_num { get { return re_num; } set { re_num = value; } }
        public string resume_Subject { get { return resumeSubject; } set { resumeSubject = value; } }
        public string resume_Location { get { return resumeLocation; } set { resumeLocation = value; } }
        public string resume_Exp { get { return resumeExp; } set { resumeExp = value; } }
        public string resume_License { get { return resumeLicense; } set { resumeLicense = value; } }
        public string resume_Content { get { return resumeContent; } set { resumeContent = value; } }
   
    }

}
