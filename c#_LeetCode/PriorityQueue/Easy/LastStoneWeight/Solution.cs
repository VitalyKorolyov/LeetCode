using System.Collections.Generic;

namespace LeetCode.PriorityQueue.Easy.LastStoneWeight;
public class Solution
{
    //https://leetcode.com/problems/last-stone-weight/description/

    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> queue = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        for (int i = 0; i < stones.Length; i++)
            queue.Enqueue(stones[i], stones[i]);

        int weight = queue.Dequeue();
        while(queue.Count > 0)
        {
            var secondWeight = queue.Dequeue();
            weight = System.Math.Abs(weight - secondWeight);

            queue.Enqueue(weight, weight);
            weight = queue.Dequeue();
        }

        return weight;
    }
}