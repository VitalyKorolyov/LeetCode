namespace LeetCode.BST.Easy.SymmetricTree
{
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

    //https://leetcode.com/problems/symmetric-tree/
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Equal(root.left, root.right);
        }

        public bool Equal(TreeNode n1, TreeNode n2)
        {
            if (n2 == null && n1 == null) return true;
            if (n2 == null || n1 == null) return false;

            return n1.val == n2.val && Equal(n1.right, n2.left) && Equal(n1.left, n2.right);
        }
    }
}