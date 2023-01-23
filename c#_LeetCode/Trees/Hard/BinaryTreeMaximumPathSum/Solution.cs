namespace LeetCode.Trees.Hard.BinaryTreeMaximumPathSum;

//https://leetcode.com/problems/binary-tree-maximum-path-sum/description/
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
    private int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root)
    {
        MaxPath(root);

        return maxSum;
    }

    private int MaxPath(TreeNode node)
    {
        if(node == null) return 0;

        var leftSum = System.Math.Max(MaxPath(node.left), 0);
        var rigthSum = System.Math.Max(MaxPath(node.right), 0);

        maxSum = System.Math.Max(maxSum, leftSum + rigthSum + node.val);

        return System.Math.Max(rigthSum + node.val, leftSum + node.val);
    }
}
