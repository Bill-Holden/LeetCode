using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Mapping
    {

        public static string FreqAlphabets(string s)
        {
            char[] input = s.ToCharArray();
            List<char> answer = new List<char>() ; // yes, it's longer than it needs to be but I don't care            

            // read in the string and tease into chunks
            for (int i = 0; i < input.Length; i++)
            {
                // if char is 1 or 2 then it could be a # example
                // check the i+2 position to see if it contains a #.  Will have to protect against going beyond end of array
                //  if(answer[i] == null) { break; }

                if ( i+2 < input.Length && input[i + 2] == '#') // need to protect against going out of bounds of array
                {                    
                    answer.Add( getChar(input[i].ToString() + input[i+1].ToString() + input[i+2].ToString()));
                    i += 2;
                    
                    continue;
                }

                answer.Add( getChar(input[i].ToString()));
                
            }
            // return mapped char per chunk
            //Characters ('a' to 'i') are represented by ('1' to '9') respectively.
            // Characters('j' to 'z') are represented by('10#' to '26#') respectively.

            string sAnswer = string.Join(null, answer);
            return sAnswer;
                
            //    answer.ForEach(delegate (char c)
            //{
            //    c.ToString();
            //});
        }

        private static char getChar(string input)
        {
            var charDictionary = new Dictionary<string, char>();
            charDictionary.Add("1", 'a');
            charDictionary.Add("2", 'b');
            charDictionary.Add("3", 'c');
            charDictionary.Add("4", 'd');
            charDictionary.Add("5", 'e');
            charDictionary.Add("6", 'f');
            charDictionary.Add("7", 'g');
            charDictionary.Add("8", 'h');
            charDictionary.Add("9", 'i');
            charDictionary.Add("10#", 'j');
            charDictionary.Add("11#", 'k');
            charDictionary.Add("12#", 'l');
            charDictionary.Add("13#", 'm');
            charDictionary.Add("14#", 'n');
            charDictionary.Add("15#", 'o');
            charDictionary.Add("16#", 'p');
            charDictionary.Add("17#", 'q');
            charDictionary.Add("18#", 'r');
            charDictionary.Add("19#", 's');
            charDictionary.Add("20#", 't');
            charDictionary.Add("21#", 'u');
            charDictionary.Add("22#", 'v');
            charDictionary.Add("23#", 'w');
            charDictionary.Add("24#", 'x');
            charDictionary.Add("25#", 'y');
            charDictionary.Add("26#", 'z');
            return charDictionary[input];
        }
    }
}
