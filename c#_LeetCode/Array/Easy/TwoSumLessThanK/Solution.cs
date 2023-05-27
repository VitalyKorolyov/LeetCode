namespace LeetCode.Array.Easy.TwoSumLessThanK;

//https://leetcode.com/problems/two-sum-less-than-k/description/
public class Solution
{
    public int TwoSumLessThanK(int[] nums, int k)
    {
        System.Array.Sort(nums);

        int i = 0;
        int j = nums.Length - 1;

        int result = -1;

        while (i < j)
        {
            int sum = nums[i] + nums[j];

            if (sum < k)
            {
                result = System.Math.Max(result, sum);
                i++;
            }
            else j--;
        }

        return result;
    }
}