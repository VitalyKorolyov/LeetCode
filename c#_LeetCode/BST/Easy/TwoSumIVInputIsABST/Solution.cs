using System.Collections.Generic;

namespace LeetCode.BST.Easy.TwoSumIVInputIsABST;

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

//https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/
public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        return FindTarget(root, k, new());
    }

    private bool FindTarget(TreeNode node, int k, HashSet<int> values)
    {
        if(node == null) return false;
        if(values.Contains(k - node.val)) return true;

        values.Add(node.val);

        return FindTarget(node.left, k, values) || FindTarget(node.right, k, values);
    }
}