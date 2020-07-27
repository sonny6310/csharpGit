using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    //개인회원 정보
    public class Customer
    {
        private string id;
        private string pw;
        private string name;
        private string addr;
        private string email;
        private string phone;

        public string ID { get { return id; } set { this.id = value; } }
        public string PW { get { return pw; } set { this.pw = value; } }
        public string NAME { get { return name; } set { this.name = value; } }
        public string ADDR { get { return addr; } set { this.addr = value; } }
        public string EMAIL { get { return email; } set { this.email = value; } }
        public string PHONE { get { return phone; } set { this.phone = value; } }
    }
}
