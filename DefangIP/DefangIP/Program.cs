using System;
using Decompress;
using StringCompression;
using System.Collections.Generic;
using Program;



namespace DefangIP
{
    
    public static class Solution
    {

        public static void Main()
        {
            string[] transactions = { "bob,627,1973,amsterdam","alex,387,885,bangkok","alex,355,1029,barcelona","alex,587,402,bangkok","chalicefy,973,830,barcelona","alex,932,86,bangkok","bob,188,989,amsterdam"   };
            int[] test = { 0, 1, 2, 3, 4, 5, 6, 0, 1 };
            int[] test2 = { 1, 3, 5, 2 };
            string[] tests = { "bella", "label", "roller" };
            string input2 = "10#11#12";

            string something = Program.Mapping.FreqAlphabets(input2);

            Ranks instanceOfRanks = new Ranks();
            string[] medals = instanceOfRanks.FindRelativeRanks(test2);
            
            
            int response4 = WordLength.LengthOfLastWord("b   a    ");
            IList<int> response2 = Program.SelfDivide.SelfDividingNumbers(1, 22);

            IList<string> transactionsResponse = Program.Invalid.InvalidTransactions(transactions);
            int[] response = ArrayIntersect.Intersect(test, test2);
            response = ArrayParity.SortArrayByParity(test);

            IList<int> smallAnswer = Smaller.CountSmaller(test);

            IList <string> answers = Common.GetValues(tests);
            int [] answer = Smaller.SmallerNumbersThanCurrent(test);

           // int response = ReduceToZero.NumberOfSteps(14);

            //response = Max69.Maximum69Number(9669);

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
