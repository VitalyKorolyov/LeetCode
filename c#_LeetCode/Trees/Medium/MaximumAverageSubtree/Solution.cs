namespace LeetCode.Trees.Medium.MaximumAverageSubtree;

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

//https://leetcode.com/problems/maximum-average-subtree/description/
public class Solution
{
    private double maxAverage = int.MinValue;

    public double MaximumAverageSubtree(TreeNode root)
    {
        Dfs(root);

        return maxAverage;
    }

    private (int, int) Dfs(TreeNode node)
    {
        if (node == null) return (0, 0);

        (int leftDescendants, int leftSum) = Dfs(node.left);
        (int rightDescendants, int rightSum) = Dfs(node.right);

        int currentDescendants = leftDescendants + rightDescendants + 1;
        int currentSum = leftSum + rightSum + node.val;
        maxAverage = System.Math.Max(maxAverage, (double)currentSum / (double)currentDescendants); ;

        return (currentDescendants, currentSum);
    }
}