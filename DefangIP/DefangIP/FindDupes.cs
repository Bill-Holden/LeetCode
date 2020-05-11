using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class FindDupes
    {
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int lastNum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            { 
                if (lastNum == nums[i]) { return lastNum; }

                lastNum = nums[i];
            }

            return 0;  /// shouldn't get here
        }
    }
}
