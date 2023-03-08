using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Graph.Hard.BusRoutes;

//https://leetcode.com/problems/bus-routes/description/
public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        int numBuses = 0;
        if (source == target) return numBuses;

        Dictionary<int, List<int>> graph = new();

        for (int bus = 0; bus < routes.Length; bus++)
            for (int j = 0; j < routes[bus].Length; j++)
            {
                var route = routes[bus][j];

                if (!graph.ContainsKey(route))
                    graph[route] = new List<int>();

                graph[route].Add(bus);
            }

        Queue<int> queue = new();
        queue.Enqueue(source);
        HashSet<int> visited = new();

        while (queue.Count > 0)
        {
            var size = queue.Count;
            numBuses++;

            for (int i = 0; i < size; i++)
            {
                var route = queue.Dequeue();

                foreach (int bus in graph[route].Where(bus => !visited.Contains(bus)))
                {
                    visited.Add(bus);
                    for (int j = 0; j < routes[bus].Length; j++)
                    {
                        if (routes[bus][j] == target) return numBuses;
                        queue.Enqueue(routes[bus][j]);
                    }
                }
            }
        }

        return -1;
    }
}