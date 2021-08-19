namespace LeetCode.BST.Easy.PathSum
{
    //https://leetcode.com/problems/path-sum/
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
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return Recursive(root, targetSum, 0);
        }

        public static bool Recursive(TreeNode root, int target, int sum)
        {
            if (root == null) return false;

            var currentSum = sum + root.val;
            if (root.left == null && root.right == null && target == currentSum) return true;

            return Recursive(root.left, target, currentSum) || Recursive(root.right, target, currentSum);
        }
    }
}