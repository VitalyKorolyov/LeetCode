namespace LeetCode.Array.Medium.CountNumberOfNiceSubarrays;

//https://leetcode.com/problems/count-number-of-nice-subarrays/description/
public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int oddcount = 0, res = 0, l = 0, count = 0;

        for (int r = 0; r < nums.Length; r++)
        {
            if (nums[r] % 2 == 1)
            {
                oddcount++;
                count = 0;
            }
            while (oddcount == k)
            {
                if (nums[l++] % 2 == 1) oddcount--;
                count++;
            }

            res += count;
        }

        return res;
    }
}