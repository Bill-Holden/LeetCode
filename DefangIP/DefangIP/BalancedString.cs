using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class BalancedString
    {
        public static int GetBalancedCount(string s)
        {
            int countOfMatches = 0;
            int countR = 0;
            int countL = 0;

            foreach (char c in s)
            {
                if (c == 'R') { countR++; }
                if (c == 'L') { countL++; }

                if (countR == countL)
                {
                    countOfMatches++;
                    countL = 0;
                    countR = 0;
                }
            }
            
            return countOfMatches;   
        }
    }
}
