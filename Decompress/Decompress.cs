using System;
using System.Collections.Generic;

namespace Decompress
{
    public static class Decompress
    {
        public static void Main()
        {            
        //    int[] input = new int[] { 1, 2, 3, 4 } ;
        //    Console.WriteLine("Input Args: {1}", input );

        //    Console.WriteLine("Result is: {1}", DecompressRLElist(input));

        }

        public static int[] DecompressRLElist(int[] nums)
        {
            // test for empty list
            // test for even number of entries in list

            List<int> listValues = new List<int>();       
            
            for (int i = 0; i < nums.Length; i+=2)
            {
                int count = nums[i];
                int value = nums[i + 1];

                for (int j = 0; j < count; j++)
                {
                    listValues.Add(value);
                }
            }

            return listValues.ToArray();
        }
    }
}
