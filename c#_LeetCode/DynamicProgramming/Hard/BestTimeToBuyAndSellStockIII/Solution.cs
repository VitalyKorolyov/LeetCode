namespace LeetCode.DynamicProgramming.Hard.BestTimeToBuyAndSellStockIII
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if(prices == null || prices.Length < 1) return 0;

            var oneBuyOneSell = 0;
            var twoBuyTwoSell = 0;
            var oneBuy = int.MaxValue;
            var twoBuy = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                oneBuy = System.Math.Min(oneBuy, prices[i]);
                oneBuyOneSell = System.Math.Max(oneBuyOneSell, prices[i] - oneBuy);
                twoBuy = System.Math.Min(twoBuy, prices[i] - oneBuyOneSell);
                twoBuyTwoSell = System.Math.Max(twoBuyTwoSell, prices[i] - twoBuy);
            }

            return twoBuyTwoSell;
        }
    }
}
