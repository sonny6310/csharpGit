using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public int mGender;
            public string mMajor;
        }
        enum Gender
        {
            Male, Female
        }
        public Form1()
        {
            InitializeComponent();

            Student[] students = new Student[3];

            students[0] = new Student() { mName = "이동준", mGender = 0, mMajor = "c#" };
            students[1] = new Student() { mName = "박명회", mGender = 0, mMajor = "java" };
            students[2] = new Student() { mName = "김은주", mGender = 1, mMajor = "oracle" };

            string tester = students[0].mGender == 0 ? "남" : "여";

            for(int i =0; i < students.Length; i++)
            {
                Label label = new Label();
                label.Text = $"이름 : {students[i].mName},  성별 : { (Gender)students[i].mGender }, 주과목 : {students[i].mMajor}";
                Controls.Add(label);
                label.AutoSize = true;
                label.Location = new Point(15, 130 +30 * i);
            }
        }
    }
}
