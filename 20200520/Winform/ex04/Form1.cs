using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
{
    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public int mId;
            public string mMajor;
            public double mGrade;
            public int mGender; //0: 남, 1: 녀

            public void mStudy()
            {
                Console.WriteLine("공부중");
            }

            public void mPlay()
            {
                Console.WriteLine("노는중");
            }
        }
        
        public Form1(vo
        {
            InitializeComponent();

            Student[] students = new Student[4];
            Student temporaryStudent1 = new Student();
            temporaryStudent1.mName = "이";
            temporaryStudent1.mId = 0909;
            temporaryStudent1.mMajor = "정보전자";
            temporaryStudent1.mGrade = 3.0;
            temporaryStudent1.mGender = 0;
            temporaryStudent1.mStudy();
            students[0] = temporaryStudent1;

            Student temporaryStudent2 = new Student();
            temporaryStudent2.mName = "김";
            temporaryStudent2.mId = 9004;
            temporaryStudent2.mMajor = "컴퓨터공학";
            temporaryStudent2.mGrade = 4.2;
            temporaryStudent2.mGender = 0;
            temporaryStudent2.mStudy();
            students[1] = temporaryStudent2;

            Student temporaryStudent3 = new Student();
            temporaryStudent3.mName = "나";
            temporaryStudent3.mId = 1004;
            temporaryStudent3.mMajor = "통계학";
            temporaryStudent3.mGrade = 3.9;
            temporaryStudent3.mGender = 1;
            temporaryStudent3.mPlay();
            students[2] = temporaryStudent3;

            Student temporaryStudent4 = new Student();
            temporaryStudent4.mName = "박";
            temporaryStudent4.mId = 0902;
            temporaryStudent4.mMajor = "수학";
            temporaryStudent4.mGrade = 3.3;
            temporaryStudent4.mGender = 0;
            temporaryStudent4.mStudy();
            students[3] = temporaryStudent4;
        }
    }
}
