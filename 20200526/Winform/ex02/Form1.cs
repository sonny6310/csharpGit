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

            Product product1 = new Product("감자", 1000);
            Product product2 = new Product("고구마", 10);
            string showtext = $"{product1.mId} : {product1.mName}" + Environment.NewLine + $"{product2.mId} : {product2.mName}" + Environment.NewLine + $"{Product.mCounter}개 생성되었습니다";
            Label label = new Label();
            label.AutoSize = true;
            label.Text = showtext;
            Controls.Add(label);
        }
    }
}
