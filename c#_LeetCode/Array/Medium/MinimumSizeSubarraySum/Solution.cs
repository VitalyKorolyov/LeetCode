namespace LeetCode.Array.Medium.MinimumSizeSubarraySum;

//https://leetcode.com/problems/minimum-size-subarray-sum/
public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minSubArrayLen = int.MaxValue;

        int j = 0;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            while (target > sum && j < nums.Length)
                sum += nums[j++];

            if (sum >= target)
                minSubArrayLen = System.Math.Min(minSubArrayLen, j - i);

            sum -= nums[i];
        }

        return minSubArrayLen == int.MaxValue ? 0 : minSubArrayLen;
    }
}