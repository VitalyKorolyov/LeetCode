using System.Collections.Generic;

namespace LeetCode.Array.Medium.MinimumCostToConnectSticks
{
    //https://leetcode.com/problems/minimum-cost-to-connect-sticks/
    public class Solution
    {
        public int ConnectSticks(int[] sticks)
        {
            var totalCost = 0;

            if (sticks.Length <= 1) return totalCost;

            var queue = new PriorityQueue<int, int>(sticks.Length);

            for (int i = 0; i < sticks.Length; i++)
                queue.Enqueue(sticks[i], sticks[i]);

            while (queue.Count > 1)
            {
                var stickF = queue.Dequeue();
                var stickS = queue.Dequeue();

                var cost = stickF + stickS;
                totalCost += cost;
                queue.Enqueue(cost, cost);
            }

            return totalCost;
        }
    }
}