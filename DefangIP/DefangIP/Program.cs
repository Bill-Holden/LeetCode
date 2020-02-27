using System;
using Decompress;
using StringCompression;
using Program;


namespace DefangIP
{

    public static class Solution
    {

        public static void Main()
        {

            int response = ReduceToZero.NumberOfSteps(14);

            response = Max69.Maximum69Number(9669);

            ListNode head = new ListNode(1);
            ListNode second = new ListNode(0);
            head.next = second;
            ListNode third = new ListNode(1);
            second.next = third;

            GetDecimalValue.GetDecimal(head);

            BalancedString.GetBalancedCount("RLRRRLLRLL");

            string stones = "aAAbbbb";
            string jewels = "aA";
           int count = JewelsAndStones.GetJewelCount(jewels, stones);

            int[] digits = { 12,345,2,6,7896    };
            int J = EvenDigits.NumEvenDigits(digits);

            int i = SubtractProdAndSum.SubtractProductAndSum(234);
            char[] values = new char[] {'a', 'a', 'b', 'b', 'c', 'c', 'c'};
            StringCompression.StringCompression.Compress(values);            


            int[] input = new int[] { 3, 2, 3, 4 ,3,3}; 
            Console.WriteLine("Result is: {1}", Decompress.Decompress.DecompressRLElist(input));
        }    
        
    };
}
