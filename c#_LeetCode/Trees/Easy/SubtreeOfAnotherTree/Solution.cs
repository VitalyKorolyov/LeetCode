namespace LeetCode.Trees.Easy.SubtreeOfAnotherTree
{
    //https://leetcode.com/problems/subtree-of-another-tree/
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
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;

            if (IsEqual(root, subRoot)) return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private static bool IsEqual(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null) return true;
            if (root == null || subRoot == null) return false;

            if (root.val != subRoot.val) return false;

            return IsEqual(root.left, subRoot.left) && IsEqual(root.right, subRoot.right);
        } 
    }
}