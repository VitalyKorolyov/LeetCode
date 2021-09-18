using System.Linq;

namespace LeetCode.DynamicProgramming.Easy.BestTimeToBuyAndSellStock
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public static class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            if (!prices.Any() || prices.Length == 1) return 0;

            int min = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                    continue;
                }

                var newMaxProfit = prices[i] - min;
                if (newMaxProfit > maxProfit)
                {
                    maxProfit = newMaxProfit;
                }
            }

            return maxProfit;
        }
    }
}