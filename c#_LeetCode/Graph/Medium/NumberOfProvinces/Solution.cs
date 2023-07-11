using System.Collections.Generic;

namespace LeetCode.Graph.Medium.NumberOfProvinces;

//https://leetcode.com/problems/number-of-provinces/description/
public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        HashSet<int> visited = new();
        int numberOfProvince = 0;

        for (int node = 0; node < isConnected.Length; node++)
        {
            if (visited.Contains(node)) continue;

            Dfs(isConnected, visited, node);
            numberOfProvince++;
        }

        return numberOfProvince;
    }

    private void Dfs(int[][] isConnected, HashSet<int> visited, int node)
    {
        visited.Add(node);

        for (int i = 0; i < isConnected[node].Length; i++)
            if (isConnected[node][i] == 1 && !visited.Contains(i))
                Dfs(isConnected, visited, i);
    }
}