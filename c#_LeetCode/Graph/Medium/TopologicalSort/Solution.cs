using System.Collections.Generic;

namespace LeetCode.Graph.Medium.TopologicalSort;

public class Solution
{
    public List<int> Sort(int vertices, int[][] edges)
    {
        List<int> sortedOrder = new ();
        if (vertices <= 0) return sortedOrder;

        // a. Initialize the graph
        Dictionary<int, int> inDegree = new(); // count of incoming edges for ev
        Dictionary<int, List<int>> graph = new(); // adjacency list graph
        for (int i = 1; i <= vertices; i++)
        {
            inDegree.Add(i, 0);
            graph.Add(i, new List<int>());
        }

        // b. Build the graph
        for (int i = 0; i < edges.Length; i++)
        {
            int parent = edges[i][0];
            int child = edges[i][1];

            graph[parent].Add(child); // put the child into it's parent's list
            inDegree[child] = inDegree[child] + 1; // increment child's inDegree
        }

        // c. Find all sources i.e., all vertices with 0 in-degrees
        Queue<int> sources = new();
        foreach (var entry in inDegree)
        {
            if (entry.Value == 0)
                sources.Enqueue(entry.Key);
        }

        // d. For each source, add it to the sortedOrder and subtract one from all of its child
        // if a child's in-degree becomes zero, add it to the sources queue
        while (sources.Count > 0)
        {
            int vertex = sources.Dequeue();
            sortedOrder.Add(vertex);

            List<int> children = graph[vertex]; // get the node's children to decrement t
            foreach (int child in children)
            {
                inDegree[child] = inDegree[child] - 1;
                if (inDegree[child] == 0)
                    sources.Enqueue(child);
            }
        }

        if (sortedOrder.Count != vertices) // topological sort is not possible as the graph ha
            return new List<int>();

        return sortedOrder;
    }
}