using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Negatives
    {
        public int CountNegatives(int[][] grid)
        {

            int answer = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < 0) { answer++; }
                }
            }

            return answer;
        }
    }
}
