using System;
using LeetCode.BST.Medium.TrimABinarySearchTree;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = Solution.TrimBST(
                new TreeNode(2, new TreeNode(1), new TreeNode(3)), 1, 4);

            Console.WriteLine(a);
        }
    }
}