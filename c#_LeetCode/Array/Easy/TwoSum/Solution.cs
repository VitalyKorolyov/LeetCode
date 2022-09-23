using System.Collections.Generic;

namespace LeetCode.Array.Easy.TwoSum
{
    //https://leetcode.com/problems/two-sum/
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (hash.ContainsKey(diff))
                    return new int[] { hash[diff], i };
                else
                {
                    if(!hash.ContainsKey(nums[i]))
                        hash.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}