using System.Collections.Generic;

namespace LeetCode.Trees.Medium.BoundaryOfBinaryTree;

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

//https://leetcode.com/problems/boundary-of-binary-tree/description/
public class Solution
{
    private readonly List<int> result = new();

    public IList<int> BoundaryOfBinaryTree(TreeNode root)
    {
        result.Add(root.val);

        AddLeftBorder(root.left);
        AddLeaves(root.left);
        AddLeaves(root.right);
        AddRightBorder(root.right);

        return result;
    }

    private void AddLeftBorder(TreeNode node)
    {
        while(node != null && (node.left != null || node.right != null))
        {
            result.Add(node.val);
            node = node.left ?? node.right;
        }
    }

    private void AddLeaves(TreeNode node)
    {
        if (node == null) return;

        AddLeaves(node.left);

        if(node.left == null && node.right == null)
            result.Add(node.val);

        AddLeaves(node.right);
    }

    private void AddRightBorder(TreeNode node)
    {
        if (node == null || (node.left == null && node.right == null)) return;

        if(node.right != null)
            AddRightBorder(node.right);
        else
            AddRightBorder(node.left);

        result.Add(node.val);
    }
}
