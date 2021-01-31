namespace LeetCode.Array.Easy.RunningSumOf1dArray
{
    //https://leetcode.com/problems/running-sum-of-1d-array/
    public class Solution
    {
        public static int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            var temp = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                temp += nums[i];
                result[i] += temp;
            }

            return result;
        }
    }
}