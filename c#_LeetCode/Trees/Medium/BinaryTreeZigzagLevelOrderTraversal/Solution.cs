using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Trees.Medium.BinaryTreeZigzagLevelOrderTraversal
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
            var res = new Dictionary<int, IList<int>>();
            if(root == null) return res.Values.ToList();

            Dfs(root, res, 0);

            foreach(var (key, item) in res)
            {
                if(key % 2 != 0) res[key] = res[key].Reverse().ToList();
            }

            return res.Values.ToList();
        }

        private void Dfs(TreeNode node, Dictionary<int, IList<int>> res, int level)
        {
            if (node == null) return;

            Add(res, node.val, level);

            Dfs(node.left, res, level + 1);
            Dfs(node.right, res, level + 1);
        }

        private void Add(Dictionary<int, IList<int>> res, int value, int level)
        {
            if (res.ContainsKey(level))
            {
                res[level].Add(value);
            }
            else
            {
                res.Add(level, new List<int> { value });
            }
        }
    }
}
