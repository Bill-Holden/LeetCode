using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class grid
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            // time to visit all points
            // diagonal and then straight line
            // Add or subtract until you hit the smaller of two dimensions.  Then add or subtract until you get to the second number

            // compare each set of numbers to the next
            int distance = 0;

            for (int i = 0; i < points.Length - 1 ; i++)
            {
                distance = points[i] [0] - points[i + 1] [0];
                int distance2 = points[i][1] - points[i + 1][1];
            }

            return distance;
        }
    }
}
