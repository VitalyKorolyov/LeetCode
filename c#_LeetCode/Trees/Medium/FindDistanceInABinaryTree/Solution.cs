namespace LeetCode.Trees.Medium.FindDistanceInABinaryTree;

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

//https://leetcode.com/problems/find-distance-in-a-binary-tree/description/
public class Solution
{
    public int FindDistance(TreeNode root, int p, int q)
    {
        var cla = GetCLA(root, p, q);

        var leftLength = GetLength(cla, p, 0);
        var rightLength = GetLength(cla, q, 0);

        return leftLength + rightLength;
    }

    private int GetLength(TreeNode node, int target, int length)
    {
        if(node == null) return -1;
        if(node.val == target) return length;

        var left = GetLength(node.left, target, length + 1);
        var right = GetLength(node.right, target, length + 1);

        return left != -1 ? left : right;
    }

    private TreeNode GetCLA(TreeNode node, int p, int q)
    {
        if(node == null) return null;
        if(p == node.val || q == node.val) return node;

        var leftRes = GetCLA(node.left, p, q);
        var rightRes = GetCLA(node.right, p, q);

        return leftRes != null && rightRes != null ? node : leftRes ?? rightRes;
    }
}