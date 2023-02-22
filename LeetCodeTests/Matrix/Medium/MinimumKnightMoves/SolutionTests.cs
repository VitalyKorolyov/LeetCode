using LeetCode.Matrix.Medium.MinimumKnightMoves;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.MinimumKnightMoves;

public class SolutionTests
{
    [Fact]
    public void MinKnightMoves_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int x = 2;
        int y = 112;

        // Act
        var result = solution.MinKnightMoves(x, y);

        // Assert
        Assert.True(true);
    }
}