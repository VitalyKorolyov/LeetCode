using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees.Medium.PathSumII
{
    //https://leetcode.com/problems/path-sum-ii/
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
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();

            Dfs(root, 0, targetSum, result, new LinkedList<int>());

            return result;
        }

        public void Dfs(TreeNode node, int sum, int targetSum, 
            IList<IList<int>> result, LinkedList<int> list)
        {
            if (node == null) return;

            var currentSum = sum + node.val;
            list.AddLast(node.val);

            if(node.left == null && node.right == null)
            {
                if (currentSum == targetSum)
                    result.Add(list.ToList());
            }
            else
            {
                Dfs(node.left, currentSum, targetSum, result, list);
                Dfs(node.right, currentSum, targetSum, result, list);
            }

            list.RemoveLast();
        }
    }
}
