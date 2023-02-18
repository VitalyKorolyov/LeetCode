using System.Collections.Generic;

namespace LeetCode.Array.Medium.LeastNumberOfUniqueIntegersAfterKRemovals;

//https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/description/
public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> frequency = new();

        for (int i = 0; i < arr.Length; i++)
        {
            if (frequency.ContainsKey(arr[i]))
                frequency[arr[i]]++;
            else frequency[arr[i]] = 1;
        }

        PriorityQueue<int, int> priorityQueue = new();
        foreach (int freq in frequency.Values)
            priorityQueue.Enqueue(freq, freq);

        while(k > 0)
        {
            var freq = priorityQueue.Dequeue();
            k -= freq;

            if (k < 0)
                priorityQueue.Enqueue(freq, freq);
        }

        return priorityQueue.Count;
    }
}