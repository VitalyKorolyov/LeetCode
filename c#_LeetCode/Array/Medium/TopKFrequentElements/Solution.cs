using System.Collections.Generic;

namespace LeetCode.Array.Medium.TopKFrequentElements
{
    //https://leetcode.com/problems/top-k-frequent-elements/
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> hash = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(nums[i]))
                    hash[nums[i]]++;
                else
                    hash.Add(nums[i], 1);
            }

            PriorityQueue<int, int> queue = new();

            foreach (var (key, v) in hash)
            {
                queue.Enqueue(key, v);
                if (queue.Count > k) queue.Dequeue();
            }

            var res = new int[k];
            for (int i = 0; i < k; i++)
                res[i] = queue.Dequeue();

            return res;
        }
    }
}
