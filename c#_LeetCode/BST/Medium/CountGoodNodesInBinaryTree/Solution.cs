namespace LeetCode.BST.Medium.CountGoodNodesInBinaryTree
{
    //https://leetcode.com/problems/count-good-nodes-in-binary-tree/
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
        private int counter = 0;
        public int GoodNodes(TreeNode root)
        {
            Count(root, root.val);
            return counter;
        }

        private void Count(TreeNode root, int prevValue)
        {
            if (root == null) return;
            if (root.val >= prevValue)
            {
                counter++;
            }

            Count(root.left, System.Math.Max(root.val, prevValue));
            Count(root.right, System.Math.Max(root.val, prevValue));
        }
    }
}