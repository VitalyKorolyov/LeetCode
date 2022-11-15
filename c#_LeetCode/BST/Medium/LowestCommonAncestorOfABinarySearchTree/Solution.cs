namespace LeetCode.BST.Medium.LowestCommonAncestorOfABinarySearchTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/description/
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if(root == null) return null;

            return Dfs(root, p, q);
        }

        private TreeNode Dfs(TreeNode node, TreeNode p, TreeNode q)
        {
            if(node == null) return null;

            if (node.val >= p.val && node.val <= q.val)
                return node;
            if (node.val <= p.val && node.val >= q.val)
                return node;

            return node.val > q.val && node.val > p.val 
                ? Dfs(node.left, p, q) 
                : Dfs(node.right, p, q);
        }
    }
}
