using System.Collections.Generic;

namespace LeetCode.Array.Medium.SubarraySumEqualsK;

//https://leetcode.com/problems/subarray-sum-equals-k/
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;

        int sum = 0;
        Dictionary<int, int> hashMap = new();
        hashMap.Add(sum, 1);
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (hashMap.ContainsKey(sum - k))
                count += hashMap[sum - k];

            hashMap[sum] = hashMap.GetValueOrDefault(sum) + 1;
        }

        return count;
    }

    public int SubarraySumN2(int[] nums, int k)
    {
        var counter = 0;

        for (int start = 0; start < nums.Length; start++)
        {
            var sum = 0;
            for (int j = start; j < nums.Length; j++)
            {
                sum += nums[j];

                if (k == sum)
                    counter++;
            }
        }

        return counter;
    }
}