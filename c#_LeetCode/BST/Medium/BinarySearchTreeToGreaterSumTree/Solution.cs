namespace LeetCode.BST.Medium.BinarySearchTreeToGreaterSumTree
{
    //https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/
    //https://leetcode.com/problems/convert-bst-to-greater-tree/
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
        private int value = 0;

        public TreeNode BstToGst(TreeNode root)
        {
            ChangeToGreater(root);

            return root;
        }

        private void ChangeToGreater(TreeNode root)
        {
            if(root == null) return;

            ChangeToGreater(root.right);
            value += root.val;
            root.val = value;
            ChangeToGreater(root.left);
        }
    }
}