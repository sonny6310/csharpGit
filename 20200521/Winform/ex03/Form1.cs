using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Student st = new Student();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "김범수", grade = 1 });
            students.Add(new Student() { name = "나얼", grade = 1 });
            students.Add(new Student() { name = "박효신", grade = 3 });
            students.Add(new Student() { name = "이수", grade = 1 });
            students.Add(new Student() { name = "이진성", grade = 2 });

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}";
                label.Location = new Point(10, 10 + (30 * i));
                label.AutoSize = true;
                Controls.Add(label);
            }

            for (int i=students.Count - 1; i >= 0; i--)
            {
                if(students[i].grade > 1)  // 1학년이 아닌 학생
                {
                    students.RemoveAt(i); // 삭제
                }
            }

            for(int i=0; i< students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}";
                label.Location = new Point(100, 10 + (30 * i));
                label.AutoSize = true;
                Controls.Add(label);
            }
        }
    }
}
