using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class EvenDigits
    {
        public static int NumEvenDigits(int[] nums)
        {
            int countOfEven = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().ToCharArray().Length % 2 == 0)
                {
                    countOfEven++;
                }
            }

            return countOfEven;
        }       
    }
}
