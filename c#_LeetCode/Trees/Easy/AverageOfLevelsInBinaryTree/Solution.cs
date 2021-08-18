using System.Collections.Generic;

namespace LeetCode.Trees.Easy.AverageOfLevelsInBinaryTree
{
    //https://leetcode.com/problems/average-of-levels-in-binary-tree/
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
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null) return new List<double>();

            var bfs = new Queue<TreeNode>();
            bfs.Enqueue(root);
            var res = new List<double>();

            while (bfs.Count > 0)
            {
                var count = bfs.Count;
                double curr = 0;

                for (var i = 0; i < count; i++)
                {
                    var node = bfs.Dequeue();
                    curr += node.val;

                    if (node.left != null)
                        bfs.Enqueue(node.left);

                    if (node.right != null)
                        bfs.Enqueue(node.right);
                }

                res.Add(curr / count);
            }

            return res;
        }
    }
}