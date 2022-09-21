namespace LeetCode.Trees.Medium.BinaryTreePruning
{
    //https://leetcode.com/problems/binary-tree-pruning/
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
        public TreeNode PruneTree(TreeNode root)
        {
            var res = Dfs(root);
            return res ? root : null;
        }

        bool Dfs(TreeNode node)
        {
            if (node == null) return false;

            bool seen = false;
            bool res = Dfs(node.left); // false
            if (res == false)
                node.left = null;
            seen = res;

            res = Dfs(node.right); //true
            if (res == false)
                node.right = null;

            seen = res || seen;

            return seen || node.val == 1;
        }
    }
}
