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
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\t\t  오라클 DB 관리 프로그램 v1.3");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(Environment.NewLine + "\t오라클 DB 연결중...");
            Oracle.getInstance().dbConnect();

            int menu;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Environment.NewLine + "--------------------------------------------------------------");
                Console.WriteLine("\t 1. 테이블 보기\t 2. 테이블 생성\t 3. 테이블 삭제");
                Console.WriteLine("\t 4. 데이터 추가\t 5. 데이터 삭제\t 6. 데이터 수정");
                Console.WriteLine("\t 7. 프로그램 종료");
                Console.WriteLine("--------------------------------------------------------------" + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("\t메뉴 선택:  ");
                int.TryParse(Console.ReadLine(), out menu);

                if (menu == 1)
                {
                    Oracle.getInstance().selectTable();
                }
                else if (menu == 2)
                {
                    Oracle.getInstance().createTable();
                }
                else if (menu == 3)
                {
                    Oracle.getInstance().dropTable();
                }
                else if (menu == 4)
                {
                    Oracle.getInstance().insertTable();
                }
                else if (menu == 5)
                {
                    Oracle.getInstance().deleteTable();
                }
                else if (menu == 6)
                {
                    Oracle.getInstance().updateTable();
                }
                else if (menu == 7)
                {
                    Console.WriteLine("\t   프로그램을 종료합니다.");
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
