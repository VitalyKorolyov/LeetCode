using System.Collections.Generic;

namespace LeetCode.Array.Easy.SortArrayByIncreasingFrequency
{
    //https://leetcode.com/problems/sort-array-by-increasing-frequency/
    public class Solution
    {
        public int[] FrequencySort(int[] nums)
        {
            var hashMap = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.ContainsKey(nums[i]))
                    hashMap[nums[i]]++;
                else hashMap.Add(nums[i], 1);
            }

            System.Array.Sort(nums, (a, b) => hashMap[a] != hashMap[b] 
                ? hashMap[a] - hashMap[b]
                : b - a);

            return nums;
        }
    }
}
