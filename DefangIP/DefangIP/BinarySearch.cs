using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{

    public class TreeNode
    {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
    }
    static class BinarySearch
    {

        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            // return the sum of all nodes who's values fall between L and R (inclusive)
            int count = 0;

            if (root.val == 0) { return 0; }

            if (L >= root.val && root.val <= R) { count += root.val; }

            count += RangeSumBST(root.left, L, Math.Min(root.val, R));
            count += RangeSumBST(root.right, Math.Max(R, root.val), R);
            return count;

        }

       

        
    }
}
