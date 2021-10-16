using System.Collections.Generic;

namespace LeetCode.BST.Medium.FindLeavesOfBinaryTree
{
    //https://leetcode.com/problems/find-leaves-of-binary-tree/
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
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            var res = new List<IList<int>>();

            GetHeight(root, res);

            return res;
        }

        private int GetHeight(TreeNode root, IList<IList<int>> res)
        {
            if (root == null) return -1;

            var leftHeight = GetHeight(root.left, res);
            var rightHeight = GetHeight(root.right, res);

            var currHeight = System.Math.Max(leftHeight, rightHeight) + 1;

            if (res.Count == currHeight)
                res.Add(new List<int>());

            res[currHeight].Add(root.val);

            return currHeight;
        }
    }
}