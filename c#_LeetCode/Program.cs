using System;
using LeetCode.BST.Easy.RangeSumOfBST;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = Solution.RangeSumBST(new TreeNode(10, new TreeNode(5, new TreeNode(3), new TreeNode(7)), new TreeNode(15, null, new TreeNode(18))), 7, 15);

            Console.WriteLine(result);
        }
    }
}