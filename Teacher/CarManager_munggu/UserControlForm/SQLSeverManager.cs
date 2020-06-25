using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlForm
{
    class SQLSeverManager
    {
        private static SQLSeverManager instance = new SQLSeverManager();

        public static SQLSeverManager getInstance()
        {
            return instance;
        }
        private string strconn = "Data Source = munggu.iptime.org,11113; Initial Catalog = mh_20200611; Persist Security Info = True; User ID = sa; Password = 8765432!";

        public string Strconn
        {
            get { return strconn; }
            set {   }
        }

        public DataSet getDataSetBoard()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                SqlCommand com = new SqlCommand("select * from board",conn);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(ds);
            }
            return ds;
        }

        public DataSet getDataSetProBoard()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                SqlCommand com = new SqlCommand("paging @fi,@se", conn);
                com.Parameters.AddWithValue("@fi", 1);
                com.Parameters.AddWithValue("@se", 10);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(ds);
            }
            return ds;
        }

        public void insertBoard()
        {
            using(SqlConnection conn = new SqlConnection(Strconn))
            {
                conn.Open();
                SqlCommand com = new SqlCommand("INSERT INTO [dbo].[board]" +
                    "           ([num]" +
                    "           ,[writer]" +
                    "           ,[email]" +
                    "           ,[subject]" +
                    "           ,[passwd]" +
                    "           ,[reg_date]" +
                    "           ,[readcount]" +
                    "           ,[ref]" +
                    "           ,[re_step]" +
                    "           ,[re_level]" +
                    "           ,[content]" +
                    "           ,[ip])" +
                    "     VALUES" +
                    "           ( (select max(num)+1 as num from board )" +
                    "           , @writer " +
                    "           , @email " +
                    "           , @subject " +
                    "           , @passwd " +
                    "           , getdate()" +
                    "           , 0" +
                    "           , 0" +
                    "           , 0" +
                    "           , 0" +
                    "           , @content" +
                    "           ,'192.168.0.198')",conn);
                com.Parameters.AddWithValue("@writer", "a");
                com.Parameters.AddWithValue("@email", "a");
                com.Parameters.AddWithValue("@subject", "a");
                com.Parameters.AddWithValue("@passwd", "a");
                com.Parameters.AddWithValue("@content", "a");

                com.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void updateBoard(string num)
        {
            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                conn.Open();
                SqlCommand com = new SqlCommand("update board set writer='a' where num = @num", conn);
                com.Parameters.AddWithValue("@num", int.Parse(num));

                com.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void deleteBoard(string num)
        {
            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                conn.Open();
                SqlCommand com = new SqlCommand("delete from board where num = @num", conn);
                com.Parameters.AddWithValue("@num", int.Parse(num));

                com.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
