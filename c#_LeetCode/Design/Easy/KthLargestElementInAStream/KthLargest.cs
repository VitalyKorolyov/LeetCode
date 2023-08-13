using System.Collections.Generic;

namespace LeetCode.Design.Easy.KthLargestElementInAStream;

//https://leetcode.com/problems/kth-largest-element-in-a-stream/
public class KthLargest
{
    private readonly int k;
    PriorityQueue<int, int> priority = new();

    public KthLargest(int k, int[] nums)
    {
        this.k = k;

        foreach (int num in nums)
            Add(num);
    }

    public int Add(int val)
    {
        priority.Enqueue(val, val);

        if(priority.Count > k)
            priority.Dequeue();

        return priority.Peek();
    }
}