using LeetCode.DynamicProgramming.Hard.BestTimeToBuyAndSellStockIII;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Hard.BestTimeToBuyAndSellStockIII;

public class SolutionTests
{
    [Fact]
    public void MaxProfit_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };

        // Act
        var result = solution.MaxProfit(prices);

        // Assert
        Assert.True(result == 6);
    }
}