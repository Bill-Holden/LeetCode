using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Ranks
    {
        int[] _nums = new int[10000];        

        public string[] FindRelativeRanks(int[] nums)
        {
            string[] answer = new string[nums.Length];
            _nums = nums;
            Array.Sort(_nums);

            for (int i = 0; i < _nums.Length; i++)
            {
                // list the top 3
                if( i == 0 ) { answer[i] = "Gold Medal"; continue; }
                if (i == 1) { answer[i] = "Silver Medal"; continue; }
                if (i == 2) { answer[i] = "Bronze Medal"; continue; }

                if( i > 2)
                {
                    int a = i + 1;
                    answer[i] = a.ToString();
                    
                    //answer[i] = GetValuePosition(i, _nums.Length).ToString();
                }                
            }

            return answer;
        }

        public int GetValuePosition(int value, int length)
        {
            for (int j = 0; j <= length; j++)
            {
                if( _nums[j] == value) { return j-1;  }
            }
            return 0;
        }
    }
}
