using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PcrommV2
{
    class DataManager
    {
        static DataManager instance;
        public static DataManager getinstance()
        {
            if (instance == null)
            {
                instance = new DataManager();
            }
            return instance;
        }
        // data 접속 
        private string upConn()
        {
            LoginData.getinstance().ReadIni();
            string upconn = "Data Source=" + LoginData.getinstance().cls_ServerAddr + ";Initial Catalog=" + LoginData.getinstance().cls_serverName
            + ";User ID=" + LoginData.getinstance().cls_serverID + ";Password=" + LoginData.getinstance().cls_serverPW;
            return upconn;
        }

        //메뉴테이블에서 메뉴 불러오기
        public DataSet pcRoomBeta(string att)
        {
            string conn = upConn();
            string attrit = "";
            if (att != "")
            {
                attrit = att;
            }
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from dbo.PcRoomBeta " + attrit, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);

                return ds;
            }
        }
        //모든메뉴불러오기
        public DataSet pcRoomAllMenu()
        {
            string conn = upConn();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select count(0) from dbo.PcRoomBeta", sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);
                return ds;
            }
        }
        //메뉴 종류의 갯수 불러오기
        public DataSet pcRoomCount(string att)
        {
            string conn = upConn();
            string attrit = "";
            if (att != "")
            {
                attrit = att + "=1";
            }
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select count(0) from dbo.PcRoomBeta where " + attrit, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
        }
        //order 데이터 보내기
        public DataSet orderAdd(string pcnum, int card, string cash, int total, string memo)
        {
            string conn = upConn();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                string time = DateTime.Now.ToString();
                SqlCommand cmd = new SqlCommand("insert into OrderTable_pay values ('" + pcnum + "'," + card + ",'" + cash + "'," + total + ",'" + memo + "', '" + time + "')", sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);
                return ds;
            }
        }
        //data 추가 
        public DataSet addMenu(string pcnum, string menu, int count)
        {
            string conn = upConn();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                string time = DateTime.Now.ToString();
                SqlCommand cmd = new SqlCommand("insert into OrderTable(pc_num,name,count,order_time) values('" + pcnum + "','" + menu + "'," + count + ", '" + time + "')", sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
        }
    }
}
