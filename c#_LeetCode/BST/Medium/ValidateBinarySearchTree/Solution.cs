using System.Collections.Generic;

namespace LeetCode.BST.Medium.ValidateBinarySearchTree
{
    //https://leetcode.com/problems/validate-binary-search-tree/
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

    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValid(root, null, null);
        }

        private bool IsValid(TreeNode root, int? low, int? high)
        {
            if (root == null) return true;

            if ((low != null && root.val <= low) || (high != null && root.val >= high))
            {
                return false;
            }

            return IsValid(root.left, low, root.val) && IsValid(root.right, root.val, high);
        }
    }
}