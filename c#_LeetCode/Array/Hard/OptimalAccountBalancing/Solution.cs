using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Hard.OptimalAccountBalancing;

//https://leetcode.com/problems/optimal-account-balancing/description/
public class Solution
{
    public int MinTransfers(int[][] transactions)
    {
        Dictionary<int, int> map = new();
        foreach (int[] trans in transactions)
        {
            map[trans[0]] = map.GetValueOrDefault(trans[0], 0) - trans[2];
            map[trans[1]] = map.GetValueOrDefault(trans[1], 0) + trans[2];
        }

        return Dfs(0, map.Values.ToArray());
    }

    private int Dfs(int index, int[] balance)
    {
        if (index == balance.Length) return 0;
        if (balance[index] == 0) return Dfs(index + 1, balance);  

        int res = int.MaxValue;
        int currDebt = balance[index];

        for (int i = index + 1; i < balance.Length; i++)
        {
            if (balance[i] * currDebt >= 0) continue;

            balance[i] += currDebt;
            res = System.Math.Min(res, 1 + Dfs(index + 1, balance));
            balance[i] -= currDebt;
        }

        return res;
    }
}