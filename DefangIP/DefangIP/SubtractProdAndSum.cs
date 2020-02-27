using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
   static class SubtractProdAndSum
    {
        public static int SubtractProductAndSum(int n)
        {
            return getProduct(n) - getSum(n);
        }

        private static int getSum(int number)
        {
            int sum = 0;
            char[] numbers = number.ToString().ToCharArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i].ToString());
            }

            return sum;
        }

        private static int getProduct(int number)
        {            
            char[] numbers = number.ToString().ToCharArray();
            int product = Convert.ToInt32(numbers[0].ToString());
            for (int i = 1; i < numbers.Length; i++)
            {
                product *= Convert.ToInt32(numbers[i].ToString());
            }

            return product;
        }
    }
}
