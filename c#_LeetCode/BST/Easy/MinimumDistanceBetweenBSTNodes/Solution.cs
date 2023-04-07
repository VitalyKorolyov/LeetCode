using System.Collections.Generic;

namespace LeetCode.BST.Easy.MinimumDistanceBetweenBSTNodes;

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

//https://leetcode.com/problems/minimum-distance-between-bst-nodes/description/
//https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/

public class Solution
{
    public int MinDiffInBST(TreeNode root)
    {
        List<int> list = new();
        Dfs(root, list);

        int minDiff = int.MaxValue;
        for (int i = 1; i < list.Count; i++)
            minDiff = System.Math.Min(minDiff, list[i] - list[i - 1]);

        return minDiff;
    }

    private void Dfs(TreeNode node, List<int> list)
    {
        if(node == null) return;

        Dfs(node.left, list);
        list.Add(node.val);
        Dfs(node.right, list);
    }
}
