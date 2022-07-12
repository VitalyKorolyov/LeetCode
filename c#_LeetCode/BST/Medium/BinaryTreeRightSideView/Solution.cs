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
            List<int> res = new();
            if(root == null) return res;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();

                    if (i == size - 1)
                        res.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }

            return res;
        }

        //public IList<int> DFS(TreeNode root)
        //{
        //    var res = new List<int>();

        //    Right(root, res, 0);

        //    return res;
        //}

        //public void Right(TreeNode root, IList<int> res, int level)
        //{
        //    if(root == null) return;

        //    if(level == res.Count)
        //        res.Add(root.val);

        //    Right(root.right, res, level + 1);
        //    Right(root.left, res, level + 1);
        //}
    }
}