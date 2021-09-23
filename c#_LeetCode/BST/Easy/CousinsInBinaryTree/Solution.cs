namespace LeetCode.BST.Easy.CousinsInBinaryTree
{
    //https://leetcode.com/problems/cousins-in-binary-tree/
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
        private int DepthX;
        private TreeNode NodeX;
        private int DepthY;
        private TreeNode NodeY;

        public bool IsCousins(TreeNode root, int x, int y)
        {
            InitDepth(root, root, 0, x, y);

            return DepthX == DepthY && NodeX != NodeY;
        }

        private void InitDepth(TreeNode root, TreeNode parent, int depth, int x, int y)
        {
            if(root == null) return;

            if (x == root.val)
            {
                DepthX = depth;
                NodeX = parent;
            }
            if (y == root.val)
            {
                DepthY = depth;
                NodeY = parent;
            }

            InitDepth(root.left, root, depth + 1, x, y);
            InitDepth(root.right, root, depth + 1, x, y);
        }
    }
}