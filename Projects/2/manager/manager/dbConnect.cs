using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager
{
    class dbConnect
    {
        #region 싱글톤
        //static dbConnect instance;
        //public static dbConnect getinstance() //싱글톤
        //{
        //    if(instance == null)
        //    {
        //        instance = new dbConnect();
        //    }
        //    return instance;
        //}
        #endregion

        //DB 접속정보
        public string conn = "Data Source=munggu.iptime.org,25000;Initial Catalog=yj_20200611;User ID=sa;Password=8765432!";

        //메뉴테이블에서 메뉴 불러오기
        public void orderDBInsert(string name, int price, int noodle, int dessert, int food, int drink, int cafe)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                //// $는 \를 사용하기 위한 방법, $@를 사용하면 변수를 values값에 바로 입력가능함
                string sql =
                    $@"insert into PcRoomBeta ( name, price, noodle, dessert, food, drink, cafe ) values ('{name}', {price}, {noodle}, {dessert}, {food}, {drink}, {cafe} )";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                cmd.ExecuteNonQuery();

                sqlconn.Close();
            }
        }

        //주문 들어오면 DB 접속해서 불러옴
        public DataSet OrderTable()
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();

                string cm = "select a.PC_Num, a.name, a.count, b.card, b.cachKinds, b.Payment, b.memo, Convert(varchar, a.Order_Time, 120) as order_time from OrderTable a, OrderTable_pay b where a.Upload = 'New' and a.PC_Num = b.PC_Num and a.Order_Time = b.Order_Time order by a.order_time asc";
                SqlCommand cmd = new SqlCommand(cm, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "OrderTable_View");


                Console.WriteLine(ds.Tables[0].Rows.Count);

                DataTable dt = ds.Tables[0];

                return ds;
            }
        }

        //주문 들어온 갯수 확인
        #region
        public DataSet orderCount()
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select count(0) from OrderTable_pay", sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);
                return ds;
            }
        }

        public DataSet orderCount_new()
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select count(distinct Order_Time) from OrderTable", sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);
                return ds;
            }
        }
        #endregion

        // 전달클릭시 old로 변경해줌 
        public void updateEnd(string time, string pcnum)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                string cm2 = "update OrderTable set Upload = 'Old' where Upload = 'New' and Order_Time = '" + time + "' and PC_Num = '" + pcnum + "'";
                SqlCommand cmd2 = new SqlCommand(cm2, sqlconn);
                cmd2.ExecuteNonQuery();
                sqlconn.Close();
            }
        }

        //update 폼, 버튼 눌렀을 때 켰을 때 전체 검색
        public DataSet MenuSelect()
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();

                sqlconn.Open();

                string sql = "SELECT name, price FROM PcRoomBeta";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);

                sqlconn.Close();
                return ds;
            }
        }

        //업데이트폼, 검색 버튼 클릭시 선택 검색
        public DataSet buttonSelect(string menuName, string searchMenu)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();

                sqlconn.Open();

                string sql = "SELECT name, price FROM PcRoomBeta WHERE " + menuName + " = 1 AND name LIKE '%" + searchMenu + "%' ";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);

                sqlconn.Close();
                return ds;
            }
        }

        //업데이트 폼, 검색 버튼 클릭시 전체에서 검색어로 검색
        public DataSet buttonSelectAll(string searchMenu)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                DataSet ds = new DataSet();
                sqlconn.Open();
                string sql = "SELECT name, price FROM PcRoomBeta WHERE name LIKE '%" + searchMenu + "%' ";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);

                sqlconn.Close();
                return ds;
            }
        }

        //업데이트 폼, 수정 버튼 클릭시
        public void update(string name1, string price1, string name2, string price2)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();

                Convert.ToInt32(price1);
                Convert.ToInt32(price2);

                //string sql = $@"update PcRoomBeta set name = '' where 'q    ' ";
                string sql = $@"update PcRoomBeta set name = '" + name2 + "', price = '" + price2 + "' where name = '" + name1 + "'";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.Add("@name", SqlDbType.Text).Value = name2;
                cmd.Parameters.Add("@price", SqlDbType.Text).Value = price2;

                cmd.ExecuteNonQuery();

                sqlconn.Close();
            }
        }

        // 업데이트 폼, 삭제 버튼 누르면 실행
        public void delete(string name)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();

                string sql = "delete from PcRoomBeta where name = '" + name + "'";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
        }
    }
}
