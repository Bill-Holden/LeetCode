using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class KthElement
    {        public int FindKthLargest(int[] nums, int k)
        {
            // find the value of the kth largest element in the array
            // sort the array
            // go to the kth element and return the value from that

            Array.Sort(nums);

            return (nums[nums.Length - (k)]);
        }
    }
}
