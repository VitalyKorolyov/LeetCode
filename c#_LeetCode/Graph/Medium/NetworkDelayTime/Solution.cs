using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Graph.Medium.NetworkDelayTime;

//https://leetcode.com/problems/network-delay-time/description/
public class Solution
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        Dictionary<int, List<(int, int)>> graph = new();

        for (int i = 1; i <= n; i++)
            graph[i] = new List<(int, int)>();

        foreach (int[] time in times)
            graph[time[0]].Add((time[1], time[2]));

        int[] minTimes = new int[n];
        for (int i = 0; i < minTimes.Length; i++)
            minTimes[i] = int.MaxValue;

        PriorityQueue<(int node, int time), int> priority = new();
        priority.Enqueue((k, 0), 0);

        while(priority.Count > 0)
        {
            var (node, time) = priority.Dequeue();

            if(time < minTimes[node - 1])
            {
                minTimes[node - 1] = time;

                foreach (var (child, weight) in graph[node])
                {
                    var currentWeight = weight + time;
                    priority.Enqueue((child, currentWeight), currentWeight);
                }
            }
        }

        var minTime = minTimes.Max();
        return minTime == int.MaxValue ? -1 : minTime;
    }
}
