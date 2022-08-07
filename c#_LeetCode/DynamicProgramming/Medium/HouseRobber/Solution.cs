namespace LeetCode.DynamicProgramming.Medium.HouseRobber
{
    //https://leetcode.com/problems/house-robber/
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if(nums == null || nums.Length == 0) return 0;
            if(nums.Length == 1) return nums[0];

            var memorization = new int[nums.Length];
            memorization[0] = nums[0];
            memorization[1] = System.Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                memorization[i] = System.Math.Max(nums[i] + memorization[i - 2], memorization[i - 1]);
            }

            return memorization[memorization.Length - 1];
        }
    }
}
