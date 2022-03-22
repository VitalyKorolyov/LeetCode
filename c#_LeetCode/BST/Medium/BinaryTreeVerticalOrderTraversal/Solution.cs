using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.BST.Medium.BinaryTreeVerticalOrderTraversal
{
    //https://leetcode.com/problems/binary-tree-vertical-order-traversal/
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
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var res = new SortedDictionary<int, IList<Tuple<int, int>>>();

            Dfs(root, 0, 0, res);

            var result = new List<IList<int>>();

            foreach (var item in res)
                result.Add(item.Value.OrderBy(x => x.Item1).Select(x => x.Item2).ToList());

            return result;
        }

        private void Dfs(TreeNode root, int column, int row, SortedDictionary<int, IList<Tuple<int, int>>> result)
        {
            if (root == null) return;

            if (result.ContainsKey(column))
                result[column].Add(Tuple.Create(row, root.val));
            else
                result.Add(column, new List<Tuple<int, int>> { Tuple.Create(row, root.val) });

            Dfs(root.left, column - 1, row + 1, result);
            Dfs(root.right, column + 1, row + 1, result);
        }
    }
}
