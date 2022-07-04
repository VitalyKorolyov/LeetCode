using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Medium.BinaryTreeLevelOrderTraversalII
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            var result = new Stack<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;
                var level = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();

                    level.Add(node.val);

                    if(node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                result.Push(level);
            }


            return result.ToList();
        }
    }
}
