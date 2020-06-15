using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_oracleConn
{
    class Program
    {
        // VS2015, oracle 11G 연결
        // 솔루션 탐색기 - 참조 우클릭 - 참조 추가 - oracle 검색 - oracle.ManagedDataAccess 4.1221 체크, 확인
        //------------------------------------------------------------------------------------------------

        static string ORADB = "Data Source=(DESCRIPTION=" +
            "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=hr;Password=1234;";

        static void dbConnect(OracleConnection conn)  // Oracle.ManagedDataAccess.Client IMPORT
        {
            try
            {
                conn.Open();
                Console.WriteLine("\t   오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                return;
            }
        }

        static void dbClose(OracleConnection conn)
        {
            try
            {
                conn.Close();
                Console.WriteLine("\t   오라클 접속 해제!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        static void selectTable(OracleConnection conn, OracleCommand cmd)
        {
            int count = 1;
            cmd.Connection = conn;
            cmd.CommandText = "select * from bigdata1 order by id asc"; // asc : 오름차순, desc : 내림차순
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine($" {count}. 이름: {dr["name"]}, 나이: {dr["age"]}, 주소: {dr["addr"]}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("\t   데이터가 없습니다.");
            }

            dr.Close();
        }

        static void createTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string query = "create table bigdata1 (id number not null, name varchar2(20) not null, age number not null, addr varchar2(80) not null, constraint pk_bigdata1_id primary key(id))";
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

        static void dropTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string query = "drop table bigdata1";
                string query2 = "drop sequence seq_id";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("\t   테이블 및 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제 에러 번호: " + e.Number);
                Console.WriteLine("테이블 삭제 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 삭제 에러 메시지: " + e.Message);
            }
        }

        static void insertTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                Console.Write("\t   이름: ");
                string name = Console.ReadLine();
                Console.Write("\t   나이: ");
                int age;
                int.TryParse(Console.ReadLine(), out age);
                Console.Write("\t   주소: ");
                string addr = Console.ReadLine();
                string query = string.Format("insert into bigdata1 values (seq_id.nextval,'{0}','{1}','{2}')", name, age, addr);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                Console.WriteLine("\tInsert 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("Insert 에러 번호: " + e.Number);
                Console.WriteLine("Insert 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("Insert 에러 메시지: " + e.Message);
            }
        }

        static void deleteTable(OracleConnection conn, OracleCommand cmd)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t   1. 전체 삭제  2.한줄 삭제");
            Console.Write("\t   선택: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int deleteMenu = int.Parse(Console.ReadLine());

            if (deleteMenu == 1)
            {
                try
                {
                    string query = "delete from bigdata1";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\tdelete 성공!");
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Delete 에러 번호: " + e.Number);
                    Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                    Console.WriteLine("Delete 에러 메시지: " + e.Message);
                }
            }
            else if (deleteMenu == 2)
            {
                try
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
                catch (OracleException e)
                {
                    Console.WriteLine("Delete 에러 번호: " + e.Number);
                    Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                    Console.WriteLine("Delete 에러 메시지: " + e.Message);
                }
            }

        }

        static void updateTable(OracleConnection conn, OracleCommand cmd)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t   1. 이름 수정  2.나이 수정  3.주소 수정");
            Console.Write("\t   선택: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int updateMenu = int.Parse(Console.ReadLine());

            if (updateMenu == 1)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 이름을 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string oldName = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   무슨 이름으로 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string newName = Console.ReadLine();
                    string query = string.Format("update bigdata1 set name='{0}' where name='{1}'",newName,oldName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\tupdate 성공!");
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Delete 에러 번호: " + e.Number);
                    Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                    Console.WriteLine("Delete 에러 메시지: " + e.Message);
                }
            }
            else if (updateMenu == 2)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   누구 나이를 변경?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string oldName = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\t   몇 살로 바꿀래?  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int newAge;
                    int.TryParse(Console.ReadLine(),out newAge);
                    string query = string.Format("update bigdata1 set age='{0}' where name='{1}'", newAge, oldName);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\tupdate 성공!");
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Delete 에러 번호: " + e.Number);
                    Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                    Console.WriteLine("Delete 에러 메시지: " + e.Message);
                }
            }
            else if (updateMenu == 3)
            {
                try
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
                catch (OracleException e)
                {
                    Console.WriteLine("Delete 에러 번호: " + e.Number);
                    Console.WriteLine("Delete 에러 코드: " + e.ErrorCode.ToString());
                    Console.WriteLine("Delete 에러 메시지: " + e.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            OracleConnection conn = new OracleConnection(ORADB);
            OracleCommand cmd = new OracleCommand(); // DML 제어 시 사용

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\t  오라클 DB 관리 프로그램 v1.0");
            Console.WriteLine("-----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(Environment.NewLine + "\t오라클 DB 연결중...");
            dbConnect(conn);

            int menu;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Environment.NewLine + "-----------------------------------------------");
                Console.WriteLine(" 1. 테이블 보기\t2. 테이블 생성 \t3. 테이블 삭제");
                Console.WriteLine(" 4. 데이터 추가\t5. 데이터 삭제 \t6. 데이터 수정");
                Console.WriteLine(" 7. 오라클 DB 접속 해제 및 프로그램 종료");
                Console.WriteLine("-----------------------------------------------" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\t메뉴 선택:  ");
                int.TryParse(Console.ReadLine(), out menu);

                if (menu == 1)
                {
                    selectTable(conn, cmd);
                }
                else if (menu == 2)
                {
                    createTable(conn, cmd);
                }
                else if (menu == 3)
                {
                    dropTable(conn, cmd);
                }
                else if (menu == 4)
                {
                    insertTable(conn, cmd);
                }
                else if (menu == 5)
                {
                    deleteTable(conn, cmd);
                }
                else if (menu == 6)
                {
                    updateTable(conn, cmd);
                }
                else if (menu == 7)
                {
                    dbClose(conn);
                    Console.WriteLine("\t   프로그램을 종료합니다." + Environment.NewLine);
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
