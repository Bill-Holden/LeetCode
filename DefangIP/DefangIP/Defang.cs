using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Defang
    {
        public static string defangIPaddr(string address)
        {
            char replaceMe = '.';
            string replaceWith = "[.]";
            string newString = "";

            foreach (char c in address)
            {
                if (c == replaceMe)
                {
                    newString += replaceWith;
                }
                else
                {
                    newString += c;
                }

            }

            return newString;
        }
    }
}
