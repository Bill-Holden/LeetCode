using System;
using System.Collections.Generic;

namespace StringCompression
{
   public static class StringCompression
    {
        public static void Main()
        {
        }
        public static int Compress(char[] chars)
        {
            // defense
            // check number of characters and make sure greater than 1
            // check that return int is less than or equal to chars.Length
            // check for numbers

            // create a place to store the list
           // List<char> results = new List<char>();
            // iterate through
            for (int i = 0; i < chars.Length; i++)
            {
                // no repeat, just add the char
               // results.Add(chars[i]);
                // if repeats, count the repeats
                int count=1;
                for (int j = i; j < chars.Length-1; j++)
                {
                    if (chars[j] == chars[j + 1])
                    {
                        count++;
                    }
                    else { break; }
                }

                // If repeat count is greater than 9, each number in the array must be in it's own spot.
                if (count > 1)
                {
                    char[] digits = count.ToString().ToCharArray();

                    for (int k = 0; k < digits.Length; k++)
                    {
                        i++;
                        chars[i]= digits[k];                        
                    }
                }

                // increment counter for i correctly.  Note the i++ in the loop
                i += (count - 1);
            }



            // return the count of values in the array
            int returncount = chars.Length;

            return returncount;
        }
    }
}
