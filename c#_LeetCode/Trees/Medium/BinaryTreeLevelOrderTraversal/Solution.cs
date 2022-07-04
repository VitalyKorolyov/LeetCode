using System.Collections.Generic;

namespace LeetCode.Trees.Medium.BinaryTreeLevelOrderTraversal
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal/
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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if(root == null) return res;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var levels = new List<int>();

                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();

                    levels.Add(node.val);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                res.Add(levels);
            }

            return res;
        }
    }
}
