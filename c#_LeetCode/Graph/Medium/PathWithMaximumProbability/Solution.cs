using System.Collections.Generic;

namespace LeetCode.Graph.Medium.PathWithMaximumProbability;

//https://leetcode.com/problems/path-with-maximum-probability/description/
public class Solution
{
    private readonly IComparer<double> comparer = 
        Comparer<double>.Create((x, y) => y.CompareTo(x));

    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
    {
        Dictionary<int, List<(int node, double prob)>> graph = new();
        for (int i = 0; i < n; i++)
            graph[i] = new List<(int node, double prob)>();

        for (int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]].Add((edges[i][1], succProb[i]));
            graph[edges[i][1]].Add((edges[i][0], succProb[i]));
        }

        double[] probabilities = new double[n];
        probabilities[start_node] = 1.0;

        PriorityQueue<(int node, double prob), double> priority = new(comparer);
        priority.Enqueue((start_node, 1.0), 1.0);

        while(priority.Count > 0)
        {
            var (node, currentNodeProb) = priority.Dequeue();

            if (node == end_node) return currentNodeProb;

            foreach (var (child, prob) in graph[node])
            {
                if(currentNodeProb * prob > probabilities[child])
                {
                    probabilities[child] = currentNodeProb * prob;
                    priority.Enqueue((child, probabilities[child]), probabilities[child]);
                }
            }
        }

        return 0.0;
    }
}