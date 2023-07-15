namespace LeetCode.Array.Medium.MaxConsecutiveOnesII;

//https://leetcode.com/problems/max-consecutive-ones-ii/description/
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int left = 0;
        int max = 0;

        int zeroCounter = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                zeroCounter++;

            while(zeroCounter > 1)
                if (nums[left++] == 0)
                    zeroCounter--;

            max = System.Math.Max(max, right - left + 1);
        }

        return max;
    }
}