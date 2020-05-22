using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] array = new int[10]; // 크기를 지정하면서 선언해야 함

            List<int> list = new List<int>(); // 크기를 지정하지 않음
            list.Add(1); // 0행에 1 저장
            list.Add(2); // 1행에 2 저장
            list.Add(3); // 2행에 3 저장
            list.RemoveAt(1); // 1행 값 삭제 => 0행: 1, 1행: 3
            foreach (var item in list)
            {
                Console.WriteLine($"list item : {item}");
            }


            List<int> list2 = new List<int>() { 1, 2, 3, 4 }; // 바로 값 넣어줘도 됨
            foreach (var item in list2)
            {
                Console.WriteLine($"item : {item}");
            }
        }
    }
}
