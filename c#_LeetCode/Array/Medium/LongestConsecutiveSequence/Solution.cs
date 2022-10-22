using System.Collections.Generic;

namespace LeetCode.Array.Medium.LongestConsecutiveSequence
{
    //https://leetcode.com/problems/longest-consecutive-sequence/
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> hash = new(nums.Length);
            HashSet<int> visited = new(nums.Length);

            for (int i = 0; i < nums.Length; i++)
                hash.Add(nums[i]);

            var longest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!visited.Contains(nums[i]))
                {
                    visited.Add(nums[i]);

                    var value = nums[i];
                    var current = 1;

                    while (hash.Contains(value - 1))
                    {
                        value--;
                        current++;
                        visited.Add(value);
                    }

                    value = nums[i];

                    while (hash.Contains(value + 1))
                    {
                        value++;
                        current++;
                        visited.Add(value);
                    }

                    longest = System.Math.Max(current, longest);
                }
            }

            return longest;
        }
    }
}
