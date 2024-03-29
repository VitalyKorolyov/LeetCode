﻿using System.Collections.Generic;

namespace LeetCode.Trees.Easy.BinaryTreeInorderTraversal
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            Recursive(root, result);

            return result;
        }

        //public IList<int> Stack(TreeNode root)
        //{
        //    var stack = new Stack<TreeNode>();
        //    var res = new List<int>();

        //    if (root == null) return res;

        //    stack.Push(root);
        //    while (stack.Count > 0)
        //    {
        //        stack.Push();
        //    }
        //}

        public static void Recursive(TreeNode root, List<int> result)
        {
            if (root == null) return;

            Recursive(root.left, result);
            result.Add(root.val);
            Recursive(root.right, result);
        }
    }
}