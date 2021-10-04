namespace LeetCode.Trees.Medium.FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
{
    //https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            return GetNode(cloned, target);
        }

        private TreeNode GetNode(TreeNode root, TreeNode target)
        {
            if (root == null) return null;
            if (root.val == target.val) return root;

            var res = GetNode(root.left, target);
            if (res != null) return res;
            return GetNode(root.right, target);
        }
    }
}