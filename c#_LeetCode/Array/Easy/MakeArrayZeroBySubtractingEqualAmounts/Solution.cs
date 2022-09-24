using System.Collections.Generic;

namespace LeetCode.Array.Easy.MakeArrayZeroBySubtractingEqualAmounts
{
    //https://leetcode.com/problems/make-array-zero-by-subtracting-equal-amounts/
    public class Solution
    {
        public int MinimumOperations(int[] nums)
        {
            HashSet<int> hash = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 || hash.Contains(nums[i]))
                    continue;
                else hash.Add(nums[i]);
            }

            return hash.Count;
        }
    }
}
