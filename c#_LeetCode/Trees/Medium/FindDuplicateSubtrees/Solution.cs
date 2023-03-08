using System.Collections.Generic;

namespace LeetCode.Trees.Medium.FindDuplicateSubtrees;

//https://leetcode.com/problems/find-duplicate-subtrees/description/
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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        List<TreeNode> res = new();
        Dfs(root, new Dictionary<string, int>(), res);

        return res;
    }

    public string Dfs(TreeNode node, Dictionary<string, int> hashMap, List<TreeNode> res)
    {
        if (node == null) return string.Empty;

        var subTree = $"({Dfs(node.left, hashMap, res)}){node.val}({Dfs(node.right, hashMap, res)})";

        hashMap[subTree] = hashMap.GetValueOrDefault(subTree, 0) + 1;

        if (hashMap[subTree] == 2)
            res.Add(node);

        return subTree;
    }
}