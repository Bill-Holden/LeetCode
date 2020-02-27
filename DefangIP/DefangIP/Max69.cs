using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Max69
    {

        public static int Maximum69Number(int num)
        {
            var charInt = num.ToString().ToCharArray();

            for(int i = 0;i < charInt.Length; i++)
            {
                if (charInt[i] == '6')
                {
                    // we can change only one.  Start with most significan bit and return
                    charInt[i] = '9';
                    string numString = new string(charInt);                    
                    return Convert.ToInt32(numString, 10);
                }

            }

            // we'll return original number if none of the chars were 6
            return num;
        }
    }
}
