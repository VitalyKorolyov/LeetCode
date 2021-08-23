namespace LeetCode.Trees.Easy.InvertBinaryTree
{
    //https://leetcode.com/problems/invert-binary-tree/
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
        public static TreeNode InvertTree(TreeNode root)
        {
            Invert(root);

            return root;
        }

        public static void Invert(TreeNode root)
        {
            if(root == null) return;

            var leftSaved = root.left;
            root.left = root.right;
            root.right = leftSaved;

            Invert(root.left);
            Invert(root.right);
        }
    }
}