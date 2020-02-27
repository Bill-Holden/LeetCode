using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class GetDecimalValue
    {
        public static int GetDecimal(ListNode head)
        {
            // iterate through the linked list
            ListNode n = head;
            List<char> binaryNums = new List<char>();       

            while (n != null)
            {
                // convert int to string to char array and then get the first item in that array
                binaryNums.Add((n.val.ToString().ToCharArray()[0]));
                n = n.next;                
            }

            // convert binary to int
            var charArray = binaryNums.ToArray();
            string numString = new string(charArray);          
            int numInt = Convert.ToInt32(numString,2);            
            return numInt;
        }
    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }
}
