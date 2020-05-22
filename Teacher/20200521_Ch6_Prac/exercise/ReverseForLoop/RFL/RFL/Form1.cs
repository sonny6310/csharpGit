using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준1", grade = 1 });//0
            students.Add(new Student() { name = "이동준2", grade = 2 });//1
            students.Add(new Student() { name = "이동준3", grade = 3 });//2
            students.Add(new Student() { name = "이동준4", grade = 1 });//3
            students.Add(new Student() { name = "이동준5", grade = 2 });//4

            for(int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.Location = new Point(13, 13 + (23 + 3) * i);
                label.AutoSize = true;
                Controls.Add(label);
            }

            for(int i = students.Count-1; i>=0; i--)
            {
                if(students[i].grade > 1)
                {
                    students.RemoveAt(i);
                }
            }

            for(int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.Location = new Point(130, 13 + (23 + 3) * i);
                label.AutoSize = true;
                Controls.Add(label);
            }









        }
    }
}
