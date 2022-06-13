namespace LeetCode.Array.Medium.MinimumSizeSubarraySum
{
    //https://leetcode.com/problems/minimum-size-subarray-sum/
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int ans = int.MaxValue;
            int left = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= target)
                {
                    ans = System.Math.Min(ans, i + 1 - left);
                    sum -= nums[left++];
                }
            }

            return (ans != int.MaxValue) ? ans : 0;
        }
    }
}
