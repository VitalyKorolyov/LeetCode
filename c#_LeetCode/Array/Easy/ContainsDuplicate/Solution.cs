using System.Collections.Generic;

namespace LeetCode.Array.Easy.ContainsDuplicate
{
    //https://leetcode.com/problems/contains-duplicate/
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>(nums.Length);

            foreach (var num in nums)
            {
                if (hash.Contains(num)) return true;
                hash.Add(num);
            }

            return false;
        }
    }
}