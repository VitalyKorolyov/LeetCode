using System.Collections.Generic;

namespace LeetCode.Graph.Medium.ReorderRoutesToMakeAllPathsLeadToTheCityZero;

//https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/description/
public class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        Dictionary<int, HashSet<int>> graph = new();
        Dictionary<int, HashSet<int>> neighborhoods = new();

        for (int i = 0; i < n; i++)
        {
            graph[i] = new HashSet<int>();
            neighborhoods[i] = new HashSet<int>();
        }

        for (int i = 0; i < connections.Length; i++)
        {
            int parent = connections[i][0];
            int child = connections[i][1];

            graph[parent].Add(child);
            neighborhoods[parent].Add(child);
            neighborhoods[child].Add(parent);
        }

        Queue<int> queue = new();
        HashSet<int> visited = new();
        visited.Add(0);
        queue.Enqueue(0);
        int change = 0;

        while(queue.Count > 0)
        {
            var city = queue.Dequeue();

            foreach (var child in neighborhoods[city]) 
            {
                if (visited.Contains(child)) continue;

                if (graph[city].Contains(child))
                    change++;

                visited.Add(child);
                queue.Enqueue(child);
            }
        }

        return change;
    }
}