using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BST.Hard.ClosestBinarySearchTreeValueII
{
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
        public IList<int> ClosestKValues(TreeNode root, double target, int k)
        {
            var queue = new PriorityQueue<int, double>();
            queue.EnsureCapacity(k);

            Dfs(root, target, queue, k);

            var res = new List<int>(k);
            for (int i = 0; i < k; i++)
                res.Add(queue.Dequeue());

            return res;
        }

        private void Dfs(TreeNode root, double target, PriorityQueue<int, double> queue, int k)
        {
            if (root == null) return;

            queue.Enqueue(root.val, System.Math.Abs(root.val - target));

            Dfs(root.left, target, queue, k);
            Dfs(root.right, target, queue, k);
        }
    }
}
