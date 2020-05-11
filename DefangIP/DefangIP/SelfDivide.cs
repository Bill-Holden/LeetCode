using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class SelfDivide
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> answers = new List<int>();
            // check for zero
            // check each digit to see if it divides into original number with zero remainder
            // create a loop to go through all numbers in the range
            for (int i = left; i <= right; i++)
            {
                if (IsSelfDivisible(i)) { answers.Add(i); }
            }

            return answers;
        }

        private static bool IsSelfDivisible(int number)
        {      
            foreach (char sNum in number.ToString().ToCharArray())
            {
                int num = Convert.ToInt32(sNum.ToString());
                if (num == 0) { return false; }
                if ((number % num) != 0) { return false; }                
            }

            return true;
        }
    }
}
