namespace LeetCode.BST.Medium.KthSmallestElementInABST
{
    //https://leetcode.com/problems/kth-smallest-element-in-a-bst/
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
        private int _k;
        private int res = 0;

        public int KthSmallest(TreeNode root, int k)
        {
            _k = k;
            Dfs(root);

            return res;
        }

        void Dfs(TreeNode node)
        {
            if(node == null) return;

            Dfs(node.left);

            if(_k == 1)
                res = node.val;
            _k--;

            Dfs(node.right);
        }
    }
}
