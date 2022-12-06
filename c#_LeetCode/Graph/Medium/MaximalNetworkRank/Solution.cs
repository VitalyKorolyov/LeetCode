using System.Collections.Generic;

namespace LeetCode.Graph.Medium.MaximalNetworkRank
{
    //https://leetcode.com/problems/maximal-network-rank/description/
    public class Solution
    {
        public int MaximalNetworkRank(int n, int[][] roads)
        {
            var graph = new Dictionary<int, HashSet<int>>();

            foreach (var road in roads)
            {
                if (graph.ContainsKey(road[0])) graph[road[0]].Add(road[1]);
                else graph.Add(road[0], new HashSet<int>() { road[1] });

                if (graph.ContainsKey(road[1])) graph[road[1]].Add(road[0]);
                else graph.Add(road[1], new HashSet<int>() { road[0] });
            }

            int max = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (!graph.ContainsKey(i)) continue;

                for (int j = i + 1; j < n; j++)
                {
                    if (!graph.ContainsKey(j)) continue;

                    int roads1 = graph[i].Count;
                    int roads2 = graph[j].Count;

                    if (graph[i].Contains(j)) roads2--;

                    max = System.Math.Max(max, roads2 + roads1);
                }
            }

            return max;
        }
    }
}
