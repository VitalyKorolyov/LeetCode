using System.Collections.Generic;

namespace LeetCode.Array.Medium.MaximumNumberOfNonOverlappingSubarraysWithSumEqualsTarget
{
    //https://leetcode.com/problems/maximum-number-of-non-overlapping-subarrays-with-sum-equals-target/
    public class Solution
    {
        public int MaxNonOverlapping(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            var prevFoundIndex = -1;
            int prefixSum = 0;
            var count = 0;

            map.Add(prefixSum, -1);

            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum += nums[i] + prefixSum;
                if (map.ContainsKey(prefixSum - target) && map[prefixSum - target] >= prevFoundIndex)
                {
                    count++;
                    prevFoundIndex = i;
                }

                if(map.ContainsKey(prefixSum))
                    map[prefixSum] = i;
                else
                    map.Add(prefixSum, i);
            }

            return count;
        }
    }
}
