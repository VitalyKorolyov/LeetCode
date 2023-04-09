namespace LeetCode.BST.Medium.ConstructBinarySearchTreeFromPreorderTraversal;

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

//https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/description/
public class Solution
{
    public TreeNode BstFromPreorder(int[] preorder)
    {
        return Bst(preorder, 0, preorder.Length - 1);
    }

    private TreeNode Bst(int[] preorder, int start, int end)
    {
        if (start > end) return null;

        TreeNode node = new(preorder[start]);
        if(start == end) return node;

        int newEnd = start;
        for (int i = newEnd + 1; i <= end && preorder[start] > preorder[i]; i++)
            newEnd = i;

        node.left = Bst(preorder, start + 1, newEnd);
        node.right = Bst(preorder, newEnd + 1, end);

        return node;
    }
}
