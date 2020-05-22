using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qz1
{
    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public string mGender;
            public string mMajor;


            public void mPrint()
            {
                Console.WriteLine($"이름: {mName}, 성별: {mGender}, 주과목: {mMajor}");
            }
        }

        public Form1()
        {
            InitializeComponent();

            Student[] students = new Student[3];
            Student stu1 = new Student();
            stu1.mName = "이동준";
            stu1.mGender = "남";
            stu1.mMajor = "C#";
            students[0] = stu1;

            Student stu2 = new Student();
            stu2.mName = "박명회";
            stu2.mGender = "남";
            stu2.mMajor = "JAVA";
            students[1] = stu2;

            Student stu3 = new Student();
            stu3.mName = "김은주";
            stu3.mGender = "여";
            stu3.mMajor = "Oracle";
            students[2] = stu3;

            stu1.mPrint();
            stu2.mPrint();
            stu3.mPrint();

            // form[디자인]에서 수동으로 만든 label에 Text 넣기
            label_st1.Text = $"이름: {stu1.mName}, 성별: {stu1.mGender}, 주과목: {stu1.mMajor}";
            label_st2.Text = $"이름: {stu2.mName}, 성별: {stu2.mGender}, 주과목: {stu2.mMajor}";
            label_st3.Text = $"이름: {stu3.mName}, 성별: {stu3.mGender}, 주과목: {stu3.mMajor}";

            for (int i = 0; i < students.Length; i++)
            {
                // label 생성
                Label label = new Label();
                // label 내용(Text) 저장
                label.Text = $"이름: {students[i].mName}, 성별: {students[i].mGender}, 주과목: {students[i].mMajor}";
                // form[디자인]에 label 추가
                Controls.Add(label);
                // label 사이즈
                label.AutoSize = true;
                // label 위치
                label.Location = new Point(10, 10 + (30 * i));
            }
        }
    }
}
