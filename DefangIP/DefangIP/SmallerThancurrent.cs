using System;
using System.Collections.Generic;

namespace Program
{
    public class Smaller
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            // Go through each number in the array and see how many numbers are less than it
            // return array of counts
            int[] answer = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) { continue; }

                    if (nums[j] < nums[i]) { count++; }
                }

                answer[i] = count;
            }

            return answer;
        }

        public static IList<int> CountSmaller(int[] nums)
        {
            int[] answer = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j <= i) { continue; }

                    if (nums[j] < nums[i]) { count++; }
                }

                answer[i] = count;
            }

            return answer;
        }
    }
}