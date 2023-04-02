namespace LeetCode.BST.Medium.ValidateBinarySearchTree;

//https://leetcode.com/problems/validate-binary-search-tree/
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
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, null, null);
    }

    private bool IsValid(TreeNode node, int? prev, bool? isLeft)
    {
        if (node == null) return true;

        if(prev.HasValue && isLeft.HasValue)
        {
            if (node.val > prev.Value && isLeft.Value) return false;
            if (node.val < prev.Value && !isLeft.Value) return false;
        }

        return IsValid(node.left, node.val, true) 
            && IsValid(node.right, node.val, false);
    }
}