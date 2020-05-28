using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qz2
{
    class Box
    {
        private double width;
        public double mWidth
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("너비는 음수일 수 없습니다.");
                    width = 0;
                }else
                {
                    width = value;
                }
            }
        }
        private double height;
        public double mHeight
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("높이는 음수일 수 없습니다.");
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(double width, double height)
        {
            mWidth = width;
            mHeight = height;
        }

        public double Area()
        {
            return width * height;
        }
    }
}
