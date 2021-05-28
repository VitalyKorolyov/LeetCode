using System.Collections.Generic;

namespace LeetCode.BST.Easy.BinaryTreeZigzagLevelOrderTraversal
{
    //https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null) result;


        }

        private 
    }
}