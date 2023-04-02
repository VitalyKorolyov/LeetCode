namespace LeetCode.BST.Easy.ClosestBinarySearchTreeValue;

//https://leetcode.com/problems/closest-binary-search-tree-value/
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
    public int ClosestValue(TreeNode root, double target)
    {
        int closest = root == null ? -1 : root.val;
        double diff = double.MaxValue;

        while (root != null)
        {
            double currentDiff = System.Math.Abs(root.val - target);
            if (currentDiff <= diff)
            {
                diff = currentDiff;
                closest = root.val;
            }

            root = root.val > target ? root.left : root.right;
        }

        return closest;
    }
}