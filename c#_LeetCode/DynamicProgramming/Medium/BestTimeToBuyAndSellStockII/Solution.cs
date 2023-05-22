namespace LeetCode.DynamicProgramming.Medium.BestTimeToBuyAndSellStockII;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        if(prices == null || prices.Length <= 1) return maxProfit;

        int minPrice = prices[0];

        for(int i = 1; i < prices.Length; i++)
        {
            if(minPrice < prices[i])
                maxProfit += prices[i] - minPrice;

            minPrice = prices[i];
        }

        return maxProfit;
    }
}