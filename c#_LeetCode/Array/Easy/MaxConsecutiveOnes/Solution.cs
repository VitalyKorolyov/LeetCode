namespace LeetCode.Array.Easy.MaxConsecutiveOnes;

//https://leetcode.com/problems/max-consecutive-ones/description/
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int left = 0;
        int max = 0;

        for(int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                left = right + 1;

            max = System.Math.Max(max, right - left + 1);
        }

        return max;
    }
}