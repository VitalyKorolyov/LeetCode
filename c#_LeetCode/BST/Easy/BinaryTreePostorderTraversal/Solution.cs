using System.Collections.Generic;

namespace LeetCode.BST.Easy.BinaryTreePostorderTraversal
{
    //https://leetcode.com/problems/binary-tree-postorder-traversal/
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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null) return res;

            Postorder(root, res);

            return res;
        }

        private void Postorder(TreeNode root, List<int> res)
        {
            if(root == null) return;

            Postorder(root.left, res);
            Postorder(root.right, res);
            res.Add(root.val);
        }
    }
}