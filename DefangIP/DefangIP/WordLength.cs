using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class WordLength
    {
        public static int LengthOfLastWord(string s)
        {
            // read in a string.  Input can be upper or lower case
            // return a count of the length of the last word
            // return 0 if last word does not exist
            // tests:
            // send in one long word
            // send in empty string
            // send in long string
            if (s == "" ) { return 0; }


            // maybe try trimming the empty space off the end before doing anything
            s = s.TrimEnd();
            //char lastChar = s.ToCharArray()[s.Length - 1];
            //char[] input = s.ToCharArray();
            string[] input = s.Split(' ');

            return input[input.Length - 1].Length;
            //if (input[input.Length-1] == ' ') 
            //{
            //    int count = 1;
            //    for (int i = input.Length - 1; i > 0; i--)
            //    {
            //        if (input[i] == ' ') { count++; }
            //    }

            //    return input[input.Length - count].ToString().Length;             
            //}

            //return input[input.Length - 1].ToString().Length;
        }

        private static int GetLastStringLocation(string s)
        {
            string[] input = s.Split(' ');
            int count = 1;
            for (int i = input.Length-1; i > 0; i--)
            {
                if( input[i] == "") { count++;  }
            }

            return count;
        }
    }
}
