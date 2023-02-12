using System.Collections.Generic;

namespace LeetCode.Trees.Medium.ConstructBinaryTreeFromPreorderAndInorderTraversal;

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

//https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/description/
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int, int> inorderValueToIndex = new(inorder.Length);

        for (int i = 0; i < inorder.Length; i++)
            inorderValueToIndex.Add(inorder[i], i);

        return Helper(0, 0, inorder.Length - 1, preorder, inorderValueToIndex);
    }

    public TreeNode Helper(int preStart, int inStart, int inEnd, int[] preorder, 
        Dictionary<int, int> inorderValueToIndex)
    {
        if (preStart > preorder.Length - 1 || inStart > inEnd) return null;

        TreeNode root = new(preorder[preStart]);

        int inIndex = inorderValueToIndex[root.val];

        root.left = Helper(preStart + 1, inStart, inIndex - 1, preorder, inorderValueToIndex);
        root.right = Helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorderValueToIndex);

        return root;
    }
}
