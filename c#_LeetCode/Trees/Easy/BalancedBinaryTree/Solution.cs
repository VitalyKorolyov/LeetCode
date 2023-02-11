namespace LeetCode.Trees.Easy.BalancedBinaryTree;
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
    //O(N) bottom up approuch
    public bool IsBalanced(TreeNode root)
    {
        return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode node)
    {
        if (node == null) return 0;

        var leftHeight = GetHeight(node.left);
        if (leftHeight == -1) return -1;

        var rightHeight = GetHeight(node.right);
        if (rightHeight == -1) return -1;

        if (System.Math.Abs(leftHeight - rightHeight) > 1) return -1;

        return System.Math.Max(leftHeight, rightHeight) + 1;
    }

    //O(N) up bottom approuch
    //private int GetHeight(TreeNode root)
    //{
    //    // An empty tree has height -1
    //    if (root == null) return -1;
    //    return 1 + System.Math.Max(GetHeight(root.left), GetHeight(root.right));
    //}

    //public bool IsBalanced(TreeNode root)
    //{
    //    // An empty tree satisfies the definition of a balanced tree
    //    if (root == null) return true;

    //    // Check if subtrees have height within 1. If they do, check if the
    //    // subtrees are balanced
    //    return System.Math.Abs(GetHeight(root.left) - GetHeight(root.right)) < 2
    //        && IsBalanced(root.left)
    //        && IsBalanced(root.right);
    //}
}
