using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_oracleConn
{
    class Oracle
    {
        static Oracle oc;

        public static string ORADB = "Data Source=(DESCRIPTION=" +
            "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=hr;Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;

        public static Oracle getInstance()
        {
            if (oc == null)
            {
                oc = new Oracle();
            }
            return oc;
        }

        public Oracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        ~Oracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t   오라클 접속 성공!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                return;
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t   오라클 접속 해제!" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void selectTable()
        {
            try
            {
                int count = 1;
                cmd.Connection = conn;
                cmd.CommandText = "select * from bigdata1 order by id asc";
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("   {0,3}.  이름: {1,-4}\t  나이: {2,3}\t주소: {3}", count, dr["name"], dr["age"], dr["addr"]);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("\t   데이터가 없습니다.");
                }

                dr.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Select 에러 번호: " + e.Number);
                Console.WriteLine("Select 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("Select 에러 메시지: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table bigdata1 " +
                    "(id number not null, name varchar2(20) not null, age number not null, addr varchar2(80) not null, " +
                    "constraint pk_bigdata1_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 = "create sequence seq_id increment by 1 start with 1";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();

                Console.WriteLine("\t   테이블 생성 및 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 번호: " + e.Number);
                Console.WriteLine("테이블 생성 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메시지: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t   정말 테이블을 삭제하시겠습니까? (Y,N)");
                Console.Write("\t   대답: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string dropAns = Console.ReadLine();

                if (dropAns == "y" || dropAns == "Y")
                {
                    string query = "drop table bigdata1";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    string query2 = "drop sequence seq_id";
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\t테이블 및 시퀀스 삭제 성공!");
                }
                else
                {
                    Console.WriteLine("\t취소하셨습니다. 선택창으로 돌아갑니다.");
                    return;
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제 에러 번호: " + e.Number);
                Console.WriteLine("테이블 삭제 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 삭제 에러 메시지: " + e.Message);
            }
        }

        public void insertTable()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t   1.한명 입력  2.랜덤 5명  3.입력 취소");
            Console.Write("\t   선택: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int insertMenu;
            int.TryParse(Console.ReadLine(), out insertMenu);

            try
            {
                if (insertMenu == 1)
                {
                    Console.Write("\t   이름: ");
                    string name = Console.ReadLine();
                    Console.Write("\t   나이: ");
                    int age;
                    int.TryParse(Console.ReadLine(), out age);
                    Console.Write("\t   주소: ");
                    string addr = Console.ReadLine();

                    // ↓ 숫자정보는 그냥, 문자정보만 홀따옴표('') 사용
                    string query = string.Format("insert into bigdata1 values (seq_id.nextval,'{0}','{1}','{2}')", name, age, addr);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tInsert 성공!");
                }
                else if (insertMenu == 2)
                {
                    int i = 0;
                    while (i < 5)
                    {
                        string name = RandData.getName();
                        int age = RandData.getAge();
                        string addr = RandData.getAddr();

                        string query = string.Format("insert into bigdata1 values (seq_id.nextval,'{0}','{1}','{2}')", name, age, addr);
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();

                        i++;
                    }
                    Console.WriteLine("\tInsert 성공!");
                }
                else
                {
                    Console.WriteLine("\t취소하셨습니다. 선택창으로 돌아갑니다.");
                    return;
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("Insert 에러 번호: " + e.Number);
                Console.WriteLine("Insert 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("Insert 에러 메시지: " + e.Message);
            }
        }

        public void deleteTable()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t   1.전체 삭제  2.한줄 삭제  3.삭제 취소");
            Console.Write("\t   선택: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int deleteMenu;
            int.TryParse(Console.ReadLine(), out deleteMenu);

            try
            {
                if (deleteMenu == 1)
                {
                    string query = "delete from bigdata1";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tdelete 성공!");
                }
                else if (deleteMenu == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 정보를 삭제?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string tableName = Console.ReadLine();

                    string query = string.Format("delete from bigdata1 where name = '{0}'", tableName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tdelete 성공!");
                }
                else
                {
                    Console.WriteLine("\t취소하셨습니다. 선택창으로 돌아갑니다.");
                    return;
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("Delete 에러 번호: " + e.Number);
                Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("Delete 에러 메시지: " + e.Message);
            }

        }

        public void updateTable()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t   1.이름 수정  2.나이 수정  3.주소 수정  4.수정 취소");
            Console.Write("\t   선택: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int updateMenu;
            int.TryParse(Console.ReadLine(), out updateMenu);

            try
            {
                if (updateMenu == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 이름을 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string oldName = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   무슨 이름으로 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string newName = Console.ReadLine();

                    string query = string.Format("update bigdata1 set name='{0}' where name='{1}'", newName, oldName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tupdate 성공!");
                }
                else if (updateMenu == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 나이를 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string oldName = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   몇 살로 바꿀래?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int newAge;
                    int.TryParse(Console.ReadLine(), out newAge);

                    string query = string.Format("update bigdata1 set age='{0}' where name='{1}'", newAge, oldName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tupdate 성공!");
                }
                else if (updateMenu == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 주소를 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string oldName = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   변경할 주소 입력:  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string newAddr = Console.ReadLine();

                    string query = string.Format("update bigdata1 set addr='{0}' where name='{1}'", newAddr, oldName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\tupdate 성공!");
                }
                else
                {
                    Console.WriteLine("\t취소하셨습니다. 선택창으로 돌아갑니다.");
                    return;
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("Delete 에러 번호: " + e.Number);
                Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("Delete 에러 메시지: " + e.Message);
            }
        }
    }
}
