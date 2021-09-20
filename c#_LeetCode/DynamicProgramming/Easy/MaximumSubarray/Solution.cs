namespace LeetCode.DynamicProgramming.Easy.MaximumSubarray
{
    //https://leetcode.com/problems/maximum-subarray/
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var current = nums[0];
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                current = System.Math.Max(nums[i], current + nums[i]);
                max = System.Math.Max(max, current);
            }

            return max;
        }

        //O(n^2)
        public int MaxSubArrayNSquared(int[] nums)
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