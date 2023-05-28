using System.Collections.Generic;

namespace LeetCode.Array.Medium.LongestConsecutiveSequence;

//https://leetcode.com/problems/longest-consecutive-sequence/
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hash = new(nums);

        int longest = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int number = nums[i];

            if (!hash.Contains(number - 1))
            {
                int currentLength = 1;

                while (hash.Contains(++number))
                    currentLength++;

                longest = System.Math.Max(longest, currentLength);
            }
        }

        return longest;
    }
}
