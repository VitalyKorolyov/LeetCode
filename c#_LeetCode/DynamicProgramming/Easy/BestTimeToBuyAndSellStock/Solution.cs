namespace LeetCode.DynamicProgramming.Easy.BestTimeToBuyAndSellStock
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public static class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                maxProfit = System.Math.Max(maxProfit, prices[i] - minPrice);
                minPrice = System.Math.Min(minPrice, prices[i]);
            }

            return maxProfit;
        }
    }
}