using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class ReduceToZero
    {

        public static int NumberOfSteps(int num)
        {
            // Checks
            // make sure it's non negative int

            int steps = 0;

            while (num != 0)
            {                // if a number is odd, subtract one then divide by 2, loop again
                if (num % 2 != 0)
                {
                    num--;
                    steps++;

                    if (num == 0) { return steps; }
                }

                // if a number is even, divide by 2 and then loop again
                num = num / 2;
                steps++;
            }

            return steps;
        }        
    }
}
