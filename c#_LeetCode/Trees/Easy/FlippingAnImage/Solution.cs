using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Easy.LeafSimilarTrees
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

    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaves1 = new List<TreeNode>();
            var leaves2 = new List<TreeNode>();

            GetLeaves(root1, leaves1);
            GetLeaves(root2, leaves2);

            foreach (var (leave1, leave2) in leaves1.Zip(leaves2))
                if (leave1.val != leave2.val) return false;

            return leaves1.Count == leaves2.Count;
        }

        private void GetLeaves(TreeNode root, List<TreeNode> leaves)
        {
            if (root == null) return;

            if(root.left == null && root.right == null)
                leaves.Add(root);

            GetLeaves(root.left, leaves);
            GetLeaves(root.right, leaves);
        }
    }
}
