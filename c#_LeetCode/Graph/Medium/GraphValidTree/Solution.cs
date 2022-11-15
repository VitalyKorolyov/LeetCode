using System.Collections.Generic;

namespace LeetCode.Graph.Medium.GraphValidTree
{
    //https://leetcode.com/problems/graph-valid-tree/description/
    public class Solution
    {
        public bool ValidTree(int n, int[][] edges)
        {
            Dictionary<int, List<int>> graph = new();

            for (int i = 0; i < edges.Length; i++)
            {
                var connection = edges[i];

                if (!graph.ContainsKey(connection[0])) 
                    graph[connection[0]] = new List<int>();
                if (!graph.ContainsKey(connection[1])) 
                    graph[connection[1]] = new List<int>();

                graph[connection[0]].Add(connection[1]);
                graph[connection[1]].Add(connection[0]);
            }

            var seen = new HashSet<int>();
            var isNoCycle = Dfs(graph, seen, 0, -1);

            return isNoCycle && seen.Count == n;
        }

        private bool Dfs(Dictionary<int, List<int>> graph, HashSet<int> visited, int node, int parent)
        {
            if(visited.Contains(node)) return false;

            visited.Add(node);

            if (graph.ContainsKey(node))
            {
                foreach (var v in graph[node])
                {
                    if(v != parent)
                    {
                        var res = Dfs(graph, visited, v, node);
                        if (res == false) return res;
                    }
                }
            }

            return true;
        }
    }
}
