using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Hard.VerticalOrderTraversalOfABinaryTree
{
    //https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/
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

    public class PointNodeComparer : IComparer<PointNode>
    {
        public int Compare(PointNode first, PointNode second)
        {
            var res = first.X.CompareTo(second.X);
            if (res != 0) return res;

            res = first.Y.CompareTo(second.Y);
            if (res != 0) return res;

            return first.Value.CompareTo(second.Value);
        }
    }

    public class PointNode
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Value { get; set; }
    }

    public class Solution
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var nodes = new List<PointNode>();
            Dfs(root, nodes, 0, 0);

            nodes.Sort(new PointNodeComparer());

            var res = new Dictionary<int, IList<int>>();
            foreach (var node in nodes)
            {
                if(res.ContainsKey(node.X))
                    res[node.X].Add(node.Value);
                else
                    res.Add(node.X, new List<int> { node.Value});
            }

            return res.Select(x => x.Value).ToList();
        }

        private void Dfs(TreeNode root, List<PointNode> nodes, int x, int y)
        {
            if (root == null) return;

            nodes.Add(new PointNode { Value = root.val, X = x, Y = y });

            Dfs(root.left, nodes, x - 1, y + 1);
            Dfs(root.right, nodes, x + 1, y + 1);
        }
    }
}
