using LeetCode.Array.Medium.CoinChange;
using Xunit;

namespace LeetCodeTests.Array.Medium.CoinChange;

public class SolutionTests
{
    [Fact]
    public void CoinChange_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] coins = new int[] { 1,2,5 };
        int amount = 100;

        // Act
        var result = solution.CoinChange(coins, amount);

        // Assert
        Assert.True(result == 20);
    }
}