using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class ReplaceHigher
    {

        public int[] ReplaceElements(int[] arr)
        {
            // Return int array, same size as input
            // for each item, replace with largest of the remaining to the right
            // The last number will always be -1

            int[] answer = new int[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                answer[i] = GetMax(i, arr);
            }
            

            answer[arr.Length - 1] = -1;
            return answer;
        }

        private static int GetMax(int startPosition, int[] arr)
        {
            int max = 0;

            for (int j = startPosition+1; j < arr.Length; j++)
            {
                if (arr[j] > max) { max = arr[j]; }
            }
                    
            return max;
        }
    }
}
