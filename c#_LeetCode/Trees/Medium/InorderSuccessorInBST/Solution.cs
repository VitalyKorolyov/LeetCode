namespace LeetCode.Trees.Medium.InorderSuccessorInBST
{
    //https://leetcode.com/problems/inorder-successor-in-bst/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        private TreeNode sueccessor;
        private int diff = int.MaxValue;

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            Dfs(root, p);

            return sueccessor;
        }

        private void Dfs(TreeNode root, TreeNode p)
        {
            if(root == null) return;

            if(root.val > p.val && root.val - p.val < diff)
            {
                sueccessor = root;
                diff = root.val - p.val;
            }

            Dfs(root.left, p);
            Dfs(root.right, p);
        }
    }
}
