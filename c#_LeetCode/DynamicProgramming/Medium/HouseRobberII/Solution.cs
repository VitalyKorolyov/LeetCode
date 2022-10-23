namespace LeetCode.DynamicProgramming.Medium.HouseRobberII
{
    //https://leetcode.com/problems/house-robber-ii/
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return System.Math.Max(nums[0], nums[1]);

            var firstProfit = GetProfit(nums, 0, nums.Length - 1);
            var secondProfit = GetProfit(nums, 1, nums.Length);

            return System.Math.Max(firstProfit, secondProfit);
        }

        private int GetProfit(int[] nums, int start, int end)
        {
            var memorization = new int[end - start];

            memorization[0] = nums[start];
            memorization[1] = System.Math.Max(nums[start], nums[start + 1]);

            for (int i = start + 2; i < end; i++)
            {
                memorization[i - start] = System.Math.Max(memorization[i - start - 1], memorization[i - start - 2] + nums[i]);
            }

            return memorization[memorization.Length - 1];
        }
    }
}
