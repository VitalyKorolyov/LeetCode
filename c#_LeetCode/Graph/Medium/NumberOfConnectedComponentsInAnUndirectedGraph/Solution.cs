using System.Collections.Generic;

namespace LeetCode.Graph.Medium.NumberOfConnectedComponentsInAnUndirectedGraph
{
    //https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/
    public class Solution
    {
        public int CountComponents(int n, int[][] edges)
        {
            var graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < edges.Length; i++)
            {
                if (!graph.ContainsKey(edges[i][0])) graph.Add(edges[i][0], new List<int> { edges[i][1] });
                else graph[edges[i][0]].Add(edges[i][1]);
                if (!graph.ContainsKey(edges[i][1])) graph.Add(edges[i][1], new List<int> { edges[i][0] });
                else graph[edges[i][1]].Add(edges[i][0]);
            }

            var counter = 0;
            HashSet<int> visited = new();
            for (int i = 0; i < n; i++)
            {
                if (visited.Contains(i)) continue;

                Dfs(graph, visited, i);
                counter++;
            }

            return counter;
        }

        private void Dfs(Dictionary<int, List<int>> graph, HashSet<int> visited, int vertice)
        {
            if(visited.Contains(vertice)) return;

            visited.Add(vertice);

            if(graph.ContainsKey(vertice))
                foreach (var verticeToVisite in graph[vertice])
                    Dfs(graph, visited, verticeToVisite);
        }
    }
}
