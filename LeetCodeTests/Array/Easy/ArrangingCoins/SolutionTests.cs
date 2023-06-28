using LeetCode.Array.Easy.ArrangingCoins;
using Xunit;

namespace LeetCodeTests.Array.Easy.ArrangingCoins;

public class SolutionTests
{
    [Fact]
    public void ArrangeCoins_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int n = 8;

        // Act
        var result = solution.ArrangeCoins(n);

        // Assert
        Assert.True(result == 3);
    }
}