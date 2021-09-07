using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Easy.BinaryTreePreorderTraversal
{
    //https://leetcode.com/problems/binary-tree-preorder-traversal/
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            Recursive(root, res);

            return res;
        }

        public void Recursive(TreeNode root, List<int> res)
        {
            if (root == null) return;
            res.Add(root.val);

            Recursive(root.left, res);
            Recursive(root.right, res);
        }

        public IList<int> Stack(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var output = new List<int>();

            if (root == null) return output;

            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node == null) continue;

                output.Add(node.val);
                stack.Push(node.right);
                stack.Push(node.left);
            }

            return output;
        }

        public IList<int> Iterative(TreeNode root)
        {
            var output = new List<int>();

            var node = root;
            while (node != null)
            {
                if (node.left == null)
                {
                    output.Add(node.val);
                    node = node.right;
                }
                else
                {
                    var predecessor = node.left;
                    while (predecessor.right != null && predecessor.right != node)
                    {
                        predecessor = predecessor.right;
                    }

                    if (predecessor.right == null)
                    {
                        output.Add(node.val);
                        predecessor.right = node;
                        node = node.left;
                    }
                    else
                    {
                        predecessor.right = null;
                        node = node.right;
                    }
                }
            }

            return output;
        }
    }
}