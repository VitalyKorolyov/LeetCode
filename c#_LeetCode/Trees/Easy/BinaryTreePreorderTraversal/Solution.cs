using System.Collections.Generic;

namespace LeetCode.Trees.Easy.BinaryTreePreorderTraversal
{
    //https://leetcode.com/problems/binary-tree-preorder-traversal/
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            Recursive(root, res);

            return res;
        }

        public void Recursive(TreeNode root, List<int> res)
        {
            if(root == null) return;
            res.Add(root.val);

            Recursive(root.left, res);
            Recursive(root.right, res);
        }
    }
}