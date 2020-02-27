using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class JewelsAndStones
    {
        public static int GetJewelCount(string jewelList, string stones)
        {
            int count = 0;

            foreach (char stone in stones)
            {
                foreach (char jewel in jewelList)
                {
                    if (stone == jewel) { count++; }
                }
            }

            return count;
        }
    }
}
