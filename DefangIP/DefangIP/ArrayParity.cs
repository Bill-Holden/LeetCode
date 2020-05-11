using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class ArrayParity
    {

        public static int[] SortArrayByParity(int[] A)
        {
            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();
            int[] answer = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] % 2) == 0)
                {
                    evenNums.Add(A[i]);
                }
                else
                {
                    oddNums.Add(A[i]);
                }
            }

            evenNums.CopyTo(answer);
            oddNums.CopyTo(answer, evenNums.Count);
            return answer;
        }
    }
}
