using System.Collections.Generic;

namespace LeetCode.Trees.Medium.PathSumIII
{
    //https://leetcode.com/problems/path-sum-iii/
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
        private int pathSum;

        public int PathSum(TreeNode root, int targetSum)
        {
            Dfs(root, 0, targetSum, new Dictionary<long, int>());

            return pathSum;
        }

        private void Dfs(TreeNode root, long sum, int target, Dictionary<long, int> hashMap)
        {
            if (root == null) return;

            sum += root.val;

            if (sum == target)
                pathSum++;

            if (hashMap.ContainsKey(sum - target))
                pathSum += hashMap[sum - target];

            if (hashMap.ContainsKey(sum))
                hashMap[sum]++;
            else hashMap.Add(sum, 1);

            Dfs(root.left, sum, target, hashMap);
            Dfs(root.right, sum, target, hashMap);

            hashMap[sum]--;
        }
    }
}
