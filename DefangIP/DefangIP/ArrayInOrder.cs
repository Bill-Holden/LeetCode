using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class ArrayInOrder
    {

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            // Create an array to store and return.  Initalize it to length of Nums arrary
            // Go through Nums and Index at the same time, incrementing each
            // Write value of Num[i] into position index[i] in the returned array

          

            List<int> tempReturn = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                {
                tempReturn.Insert(index[i], nums[i]);                
                }

            return tempReturn.ToArray();
        }
    }
}
