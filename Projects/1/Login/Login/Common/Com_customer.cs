using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    // 기업회원 정보
    public class Com_customer
    {
        private string id;
        private string pw;
        private string name;
        private string addr;
        private string com_name;
        private string com_addr;
        private string com_num;
        private string phone;
        private string com_tel;
        private string email;

        public Com_customer()
        {

        }

        public string ID { get { return id; } set { this.id = value; } }
        public string PW { get { return pw; } set { this.pw = value; } }
        public string NAME { get { return name; } set { this.name = value; } }
        public string ADDR { get { return addr; } set { this.addr = value; } }
        public string COM_NAME { get { return com_name; } set { this.com_name = value; } }
        public string COM_ADDR { get { return com_addr; } set { this.com_addr = value; } }
        public string COM_NUM { get { return com_num; } set { this.com_num = value; } }
        public string PHONE { get { return phone; } set { this.phone = value; } }
        public string COM_TEL { get { return com_tel; } set { this.com_tel = value; } }
        public string EMAIL { get { return email; } set { this.email = value; } }
    }
}
