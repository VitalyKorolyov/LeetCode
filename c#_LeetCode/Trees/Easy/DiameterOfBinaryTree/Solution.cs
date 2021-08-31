namespace LeetCode.Trees.Easy.DiameterOfBinaryTree
{
    //https://leetcode.com/problems/diameter-of-binary-tree/submissions/
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
        private static int _max = 0;

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            Diameter(root);

            return _max;
        }

        private static int Diameter(TreeNode root)
        {
            if (root == null) return 0;

            var left = Diameter(root.left);
            var right = Diameter(root.right);

            _max = System.Math.Max(_max, left + right);

            return System.Math.Max(left, right) + 1;
        }
    }
}