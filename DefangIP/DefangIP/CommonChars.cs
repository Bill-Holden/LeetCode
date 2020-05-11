using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Common
    {
        // If the char exists in each string, add it to the output
        // If the char exists twice in each string, add it to the output.  Need to avoid using one char to count for two instances
        //
        public static IList<string> CommonChars(string[] A)
        {
            List<string> answers = new List<string>();

            foreach (char c in A[0])
            {
               
                bool isInEachString = true;
                // start on second string
                for (int i = 1; i < A.Length; i++)
                {
                    bool isInOneChar = false;
                    int charCount = 1;

                    foreach (char c2 in A[i])
                    {
                        if (c2 != c) { break; }

                        if ((c2 == c) && (!answers.Contains(c.ToString())))
                        {
                            isInOneChar = true;                           
                            break;
                        }
                        else //There's already an instance of this char in the answers and there's a match
                        {
                            // number of char in A[0] must be equal to number of char in A[i]
                            // get a count of how many are in the answer
                            // iterate through each char in each string and if there are count +1 instances, add it to answer
                            charCount++;
                            int count = getCount(answers, c2) + 1;
                            if (charCount == count)
                            {
                                isInOneChar = true;
                                break;
                            }
                        }
                    }

                    if (isInOneChar == false)
                    {
                        isInEachString = false;
                        break;
                    }
                }

                if (isInEachString) { answers.Add(c.ToString()); }
                
            }

            
            return answers;
        }

        private static int getCount(List<string> answers, char cToCount)
        {
            int count = 0;

            for (int i = 0; i < answers.Count; i++)
            {
                char[] cArray = answers[0].ToCharArray(); 
                
                if ((char)cArray.GetValue(0) == cToCount) { count++; }                
            }

            return count;
        }

        private static int getCount(string word, char charToCount)
        {
            int count = 0;
            char[] wordArray = word.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == charToCount) { count++; }
            }

            return count;
        }

        public static IList<string> GetValues(string[] A)
        {
            IList<string> answers = new List<string>();
            char[] firstWord = A[0].ToCharArray();              
               
                // for each char, get a count
                foreach (char c in firstWord)
                {
                    int minCount = 10;
                    // go through each word and get the min count
                    for (int j = 0; j < A.Length; j++)
                    {                       
                            int count = getCount(A[j], c);
                            
                            if (count < minCount)
                            {
                                minCount = count;                               
                            }                          
                    }

                // if answers already contains this char, don't process
                    if (!answers.Contains(c.ToString()))
                    {
                        // we have mincount.  If it's zero, do nothing.  otherwise add to answers 
                        for (int k = 0; k < minCount; k++)
                        {
                            answers.Add(c.ToString());
                        }
                    }
                }
            //iterate through minCount and add to answers
            return answers;
        }
    }
}


// take first string, go through each and get a count for each char.  Two dimension array?
// for each char in the first, get a count of those same chars in each string
// figure out the min number of that char and write it to the answers.  Min count of all the counts.