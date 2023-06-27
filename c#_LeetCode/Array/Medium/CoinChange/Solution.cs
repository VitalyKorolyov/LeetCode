using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.CoinChange;

//https://leetcode.com/problems/coin-change/description/
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        var result = CoinChange(coins, amount, new Dictionary<int, int>());
        return result == int.MaxValue ? -1 : result;
    }

    private int CoinChange(int[] coins, int amount, Dictionary<int, int> visited)
    {
        if (amount == 0) return 0;
        if (amount < 0) return int.MaxValue;
        if (visited.ContainsKey(amount)) return visited[amount];

        int min = int.MaxValue;

        for(int i = 0; i < coins.Length; i++)
        {
            var result = CoinChange(coins, amount - coins.ElementAt(i), visited);

            if(result != int.MaxValue)
                min = System.Math.Min(min, result + 1);
        }

        if (!visited.ContainsKey(amount))
            visited[amount] = min;

        return min;
    }
}