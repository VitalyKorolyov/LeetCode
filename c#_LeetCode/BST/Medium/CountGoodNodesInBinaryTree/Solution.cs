namespace LeetCode.BST.Medium.CountGoodNodesInBinaryTree
{
    //https://leetcode.com/problems/count-good-nodes-in-binary-tree/
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
        public int GoodNodes(TreeNode root)
        {
            return Count(root, root.val);
        }

        private int Count(TreeNode root, int prevValue)
        {
            if (root == null) return 0;

            var counter = root.val >= prevValue ? 1 : 0; 

            return counter + Count(root.left, System.Math.Max(root.val, prevValue)) 
                + Count(root.right, System.Math.Max(root.val, prevValue));
        }
    }
}