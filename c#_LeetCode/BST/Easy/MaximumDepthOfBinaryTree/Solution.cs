using System;

namespace LeetCode.BST.Easy.MaximumDepthOfBinaryTree
{

    //https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class Solution
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}