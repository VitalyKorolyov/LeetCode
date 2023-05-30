namespace LeetCode.Trees.Medium.LowestCommonAncestorOfABinaryTree;

//https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
}

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null) return null;

        if(root.val == p.val || root.val == q.val) return root;

        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode rigth = LowestCommonAncestor(root.right, p, q);

        if (left != null && rigth != null) return root;

        return left ?? rigth;
    }
}