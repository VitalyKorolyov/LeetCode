namespace LeetCode.Trees.Easy.MinimumDepthOfBinaryTree
{
    //https://leetcode.com/problems/minimum-depth-of-binary-tree
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
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left = MinDepth(root.left);
            int right = MinDepth(root.right);
            return (left == 0 || right == 0) ? left + right + 1 : System.Math.Min(left, right) + 1;
        }
    }
}