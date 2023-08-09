using System.Collections.Generic;

namespace LeetCode.Graph.Medium.GraphValidTree;

//https://leetcode.com/problems/graph-valid-tree/description/
public class Solution
{
    public bool ValidTree(int n, int[][] edges)
    {
        Dictionary<int, List<int>> graph = new();

        for (int i = 0; i < n; i++)
            graph[i] = new List<int>();

        for (int i = 0; i < edges.Length;i++)
        {
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);
        }

        HashSet<int> visited = new();

        var isCycle = Dfs(graph, visited, 0, -1);

        return visited.Count == n && !isCycle;
    }

    private bool Dfs(Dictionary<int, List<int>> grid, HashSet<int> visited, int node, int parent)
    {
        if(visited.Contains(node)) return true;

        visited.Add(node);

        if (grid.ContainsKey(node))
        {
            foreach (var currentNode in grid[node])
            {
                if (currentNode == parent) continue;

                var isCycle = Dfs(grid, visited, currentNode, parent);
                if(isCycle) return true;
            }
        }

        return false;
    }
}
