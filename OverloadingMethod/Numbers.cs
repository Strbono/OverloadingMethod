using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int minimum;
            if (number1 < number2)
                minimum = number1;
            else
                minimum = number2;
            return minimum;            

        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int minimum;
            int E = (int)number3;
            if (number2 < number1 && number2 < E)
                minimum = number2;
            else
                minimum = E;
            return minimum;
    
        }

        public int FindMaximum(int number1, int number2)
        {
            int maximum;
            if (number1 > number2)
                maximum = number1;
            else
                maximum = number2;

            return maximum;


        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int maximum;
            int X = (int)number3;
            if (number1 > number2 && number1 > X)
                maximum = number1;
            else
              maximum = X;
            return maximum;

        }
    }
}
