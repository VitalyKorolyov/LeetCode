using System;
using System.Linq;
using System.Text;

namespace LeetCode.Trees.Medium.StepByStepDirectionsFromABinaryTreeNodeToAnother
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

    //https://leetcode.com/problems/step-by-step-directions-from-a-binary-tree-node-to-another/description/
    public class Solution
    {
        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            StringBuilder s = new StringBuilder();
            StringBuilder d = new StringBuilder();

            Find(root, startValue, s);
            Find(root, destValue, d);

            int i = 0, min = System.Math.Min(d.Length, s.Length);
            while (i < min && s[s.Length - i - 1] == d[d.Length - i - 1])
                i++;

            StringBuilder lR = new();
            foreach (var item in Enumerable.Repeat("U", s.Length - i))
                lR.Append(item);

            StringBuilder rR = new();
            foreach (var item in d.ToString().Reverse())
                rR.Append(item);

            return lR.ToString() + rR.ToString().Substring(i);
        }

        private bool Find(TreeNode n, int val, StringBuilder sb)
        {
            if (n.val == val) return true;

            if (n.left != null && Find(n.left, val, sb))
                sb.Append("L");
            else if (n.right != null && Find(n.right, val, sb))
                sb.Append("R");

            return sb.Length > 0;
        }
    }
}
