using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class ArrayIntersect
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            // Find all numbers that are in both arrays
            // Take smaller array and work with that.  Should be more efficient
            // If the number is in both twice, it should be listed twice in output

            List<int> answers = new List<int>();
            

            // for each char, get a count
            for( int i = 0; i < nums1.Length; i++)
            {
                int count1 = getCount(nums2, nums1[i]);
                int count2 = getCount(nums1, nums1[i]);

                int count = count1 < count2 ? count1 : count2;             

                // if answers already contains this char, don't process
                if (!answers.Contains(nums1[i]))
                {
                    // we have mincount.  If it's zero, do nothing.  otherwise add to answers 
                    for (int k = 0; k < count; k++)
                    {
                        answers.Add(nums1[i]);
                    }
                }
            }
            //iterate through minCount and add to answers
            return answers.ToArray();
        }

        private static int getCount(int[] nums, int numToCount)
        {
            int count = 0;
            

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == numToCount) { count++; }
            }

            return count;
        }
    }
}


