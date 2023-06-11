namespace LeetCode.DynamicProgramming.Hard.BestTimeToBuyAndSellStockIII;

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if(prices == null || prices.Length <= 1) return 0;

        int[] leftProfit = new int[prices.Length];
        int[] rightProfit = new int[prices.Length + 1];

        int maxProfit = 0;
        int minPrice = prices[0];
        for(int i = 1; i < prices.Length; i++)
        {
            maxProfit = System.Math.Max(maxProfit, prices[i] - minPrice);
            minPrice = System.Math.Min(minPrice, prices[i]);
            leftProfit[i] = maxProfit;
        }

        maxProfit = 0;
        int maxPrice = prices[prices.Length - 1];
        for (int i = prices.Length - 2; i >= 0; i--)
        {
            maxProfit = System.Math.Max(maxProfit, maxPrice - prices[i]);
            maxPrice = System.Math.Max(maxPrice, prices[i]);
            rightProfit[i] = maxProfit;
        }

        maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
            maxProfit = System.Math.Max(maxProfit, rightProfit[i + 1] + leftProfit[i]);

        return maxProfit;
    }
}