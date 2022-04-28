namespace LeetCode.Trees.Medium.LowestCommonAncestorOfABinaryTree
{
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
    }

    public class Solution
    {
        private TreeNode lowerCommonAnsestor = null;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            FindLowerCommonAncestor(root, p, q);
            return lowerCommonAnsestor;
        }

        private bool FindLowerCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            // If reached the end of a branch, return false.
            if (root == null) return false;

            // Left Recursion. If left recursion returns true, set left = 1 else 0
            int left = FindLowerCommonAncestor(root.left, p, q) ? 1 : 0;

            // Right Recursion
            int right = FindLowerCommonAncestor(root.right, p, q) ? 1 : 0;

            // If the current node is one of p or q
            int mid = (root.val == p.val || root.val == q.val) ? 1 : 0;

            // If any two of the flags left, right or mid become True
            if (mid + left + right >= 2)
                lowerCommonAnsestor = root;

            // Return true if any one of the three bool values is True.
            return (mid + left + right > 0);
        }
    }
}
