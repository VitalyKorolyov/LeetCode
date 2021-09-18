namespace LeetCode.DynamicProgramming.Easy.MaximumSubarray
{
    //https://leetcode.com/problems/maximum-subarray/
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var maxSum = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                var currentSum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    maxSum = System.Math.Max(maxSum, currentSum);
                }
            }

            return maxSum;
        }
    }
}