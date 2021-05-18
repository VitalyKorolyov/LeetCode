using LeetCode.Array.Easy.BestTimeToBuyAndSellStock;
using Xunit;

namespace LeetCodeTests.Array.Easy.BestTimeToBuyAndSellStock
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var result = Solution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
            Assert.Equal(0, result);

            result = Solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
            Assert.Equal(5, result);

            result = Solution.MaxProfit(new int[] { });
            Assert.Equal(0, result);

            result = Solution.MaxProfit(new[] { 1 });
            Assert.Equal(0, result);

            result = Solution.MaxProfit(new[] { 1, 2 });
            Assert.Equal(1, result);

            result = Solution.MaxProfit(new[] { 2, 4, 1 });
            Assert.Equal(2, result);

            result = Solution.MaxProfit(new[] { 2, 1, 2, 1, 0, 1, 2 });
            Assert.Equal(2, result);
        }
    }
}