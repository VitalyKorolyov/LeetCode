using System.Collections.Generic;

namespace LeetCode.BST.Medium.BinaryTreeRightSideView
{
    //https://leetcode.com/problems/binary-tree-right-side-view/
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
        public IList<int> RightSideView(TreeNode root)
        {
            var res = new List<int>();
            if (root == null) return res;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            TreeNode prev, curr = root;
            while (queue.Count != 0)
            {
                prev = curr;
                curr = queue.Dequeue();

                while (curr != null)
                {
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }

                    prev = curr;
                    curr = queue.Dequeue();
                }

                res.Add(prev.val);

                if (queue.Count != 0)
                    queue.Enqueue(null);
            }
            return res;
        }

        public IList<int> DFS(TreeNode root)
        {
            var res = new List<int>();

            Right(root, res, 0);

            return res;
        }

        public void Right(TreeNode root, IList<int> res, int level)
        {
            if(root == null) return;

            if(level == res.Count)
                res.Add(root.val);

            Right(root.right, res, level + 1);
            Right(root.left, res, level + 1);
        }
    }
}