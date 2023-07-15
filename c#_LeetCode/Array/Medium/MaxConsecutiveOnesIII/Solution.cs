namespace LeetCode.Array.Medium.MaxConsecutiveOnesIII;

//https://leetcode.com/problems/max-consecutive-ones-iii/description/
public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int counter = 0;
        int maxLength = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                counter++;

            while (counter > k)
                if (nums[left++] == 0)
                    counter--;

            maxLength = System.Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}