﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Cal2
    {
        public static int Power(int input)
        {
            return input * input;
        }

        public static int Power(int input, int count)
        {
            int output = 1;
            for (int i = 0; i < count; i++)
            {
                output *= input;
            }
            return output;
        }
        public static int SumAll(int end)
        {
            return SumAll(0, end);

        }
        public static int SumAll(int start, int end)
        {
            int output = 0;
            for (int i = start; i < end + 1; i++)
            {
                output += i;
            }
            return output;
        }
    }
}
