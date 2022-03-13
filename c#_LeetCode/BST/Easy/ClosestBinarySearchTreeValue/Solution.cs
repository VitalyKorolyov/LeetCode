using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BST.Easy.ClosestBinarySearchTreeValue
{
    //https://leetcode.com/problems/closest-binary-search-tree-value/
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
        public int ClosestValue(TreeNode root, double target)
        {
            int closest = root.val;

            while (root != null)
            {
                closest = System.Math.Abs(root.val - target) < System.Math.Abs(closest - target) 
                    ? root.val
                    : closest;

                root = target < root.val ? root.left : root.right;
            }

            return closest;
        }
    }
}
