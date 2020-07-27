using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PcrommV2
{
    class LoginData
    {
        /* .ini파일 쓰는 함수
         * string section : [section]
         * string key : 값의 키 (val의 key)
         * string val : 키의 값 (key의 val)
         * filePath  : 쓸 ini 파일경로
         */
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val,
                                                            string filePath);
        /*  .ini파일 읽는 함수
        * string section : 가져올 값의 키가 속해있는 섹션이름
        * string key : 가져올 값의 키이름
        * string def : 키의 값이 없을경우 기본값(default)
        * StringBuilder retVal : 가져올 값
        * int size : 가져올 값의 길이
        * string filePath : 읽어올 ini 파일경로
        * 
        * return value : 읽어들여온 데이터 길이
        */
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def,
                                                StringBuilder retVal, int size, string filePath);
        static LoginData instance;
        public static LoginData getinstance()
        {
            if (instance == null)
            {
                instance = new LoginData();
            }
            return instance;
        }
        //폴더 생성
        DirectoryInfo di = new DirectoryInfo(@"c:\test");
        // ini파일경로
        static string path = "C:\\test\\Test.ini";
        public void WriteIni(string pcNum, string serverAddr, string serverName, string serverId, string serverPw)
        {
            creatForder();
            WriteIniFile("USER_INFO", "PCNum", pcNum, path);
            WriteIniFile("USER_INFO", "ServerAddr", serverAddr, path);
            WriteIniFile("USER_INFO", "ServerName", serverName, path);
            WriteIniFile("USER_INFO", "ServerID", serverId, path);
            WriteIniFile("USER_INFO", "ServerPW", serverPw, path);
        }
        public string cls_Pcnum = string.Empty;
        public string cls_ServerAddr = string.Empty;
        public string cls_serverName = string.Empty;
        public string cls_serverID = string.Empty;
        public string cls_serverPW = string.Empty;
        public void ReadIni()
        {
            var pcNum = ReadIniFile("USER_INFO", "PCNum", path);
            var serverAddr = ReadIniFile("USER_INFO", "ServerAddr", path);
            var serverName = ReadIniFile("USER_INFO", "ServerName", path);
            var serverID = ReadIniFile("USER_INFO", "ServerID", path);
            var serverPW = ReadIniFile("USER_INFO", "ServerPW", path);
            cls_Pcnum = pcNum;
            cls_ServerAddr = serverAddr;
            cls_serverName = serverName;
            cls_serverID = serverID;
            cls_serverPW = serverPW;

        }
        // ini쓰기
        private void WriteIniFile(string section, string key, string value, string path)
        {
            WritePrivateProfileString(section, key, value, path);
        }
        // ini읽기
        private string ReadIniFile(string section, string key, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", sb, sb.Capacity, path);

            return sb.ToString();
        }
        //폴더 만드는 함수
        private void creatForder()
        {
            if (di.Exists == false)
            {
                di.Create();
            }
        }
    }
}
