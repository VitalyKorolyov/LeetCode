using System.Collections.Generic;

namespace LeetCode.Graph.Medium.CheapestFlightsWithinKStops;

//https://leetcode.com/problems/cheapest-flights-within-k-stops/description/
public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        Dictionary<int, List<(int city, int price)>> graph = new();
        for (int i = 0; i < n; i++)
            graph[i] = new List<(int city, int price)>();

        foreach (int[] flight in flights)
            graph[flight[0]].Add((flight[1], flight[2]));

        int[] prices = new int[n];
        System.Array.Fill(prices, int.MaxValue);

        Queue<(int city, int price, int stops)> queue = new();
        queue.Enqueue((src, 0, 0));

        while (queue.Count > 0)
        {
            var (city, cost, stops) = queue.Dequeue();

            if (stops > k) continue;

            foreach (var (nextCity, currentCost) in graph[city])
            {
                int newCost = currentCost + cost;

                if (prices[nextCity] < newCost) continue;

                prices[nextCity] = newCost;
                queue.Enqueue((nextCity, newCost, stops + 1));
            }
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}