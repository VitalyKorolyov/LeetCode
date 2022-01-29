using System;

namespace LeetCode.Array.Easy.MinCostClimbingStairs
{
    //https://leetcode.com/problems/min-cost-climbing-stairs/
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            Span<int> route = stackalloc int[cost.Length + 1];

            for (int i = 2; i <= cost.Length; i++)
            {
                int takeOneStep = route[i - 1] + cost[i - 1];
                int takeTwoSteps = route[i - 2] + cost[i - 2];
                route[i] = System.Math.Min(takeOneStep, takeTwoSteps);
            }

            return route[route.Length - 1];
        }
    }
}
