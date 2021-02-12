using System.Linq;

namespace LeetCode.BST.Easy.ConvertSortedArrayToBinarySearchTree
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

    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    public class Solution
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return !nums.Any() ? null : Build(nums, 0, nums.Length - 1);
        }

        private static TreeNode Build(int[] nums, int low, int high)
        {
            if (low > high) return null;

            var middle = (low + high) / 2;

            var treeNode = new TreeNode(nums[middle])
            {
                left = Build(nums, low, middle - 1), 
                right = Build(nums, middle + 1, high)
            };

            return treeNode;
        }
    }
}