using System.Collections.Generic;
using System.Linq;

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
            var res = new List<IList<int>>();
            if (root == null) return res;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool leftToRight = true;

            while(queue.Count > 0)
            {
                var level = new LinkedList<int>();

                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();

                    if (leftToRight)
                        level.AddLast(node.val);
                    else
                        level.AddFirst(node.val);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                leftToRight = !leftToRight;
                res.Add(level.ToList());
            }

            return res;
        }
    }
}
