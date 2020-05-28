using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Calculate
    {
        public int Power(int input)
        {
            return input * input;
        }

        public int Power(int input, int count)
        {
            int output = 1;
            for(int i = 0; i< count; i++)
            {
                output = output * input;
            }
            return output;
        }

        public int SumAll(int end)
        {
           return SumAll(0, end);
        }

        public int SumAll(int start, int end)
        {
            int output = 0;
            for(int i = start; i <= end; i++)
            {
                output += i;
            }
            return output;
        }
    }
}
