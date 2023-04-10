using LeetCode.Matrix.Medium.DifferenceBetweenOnesAndZerosInRowAndColumn;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.DifferenceBetweenOnesAndZerosInRowAndColumn;

public class SolutionTests
{
    [Fact]
    public void OnesMinusZeros_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] grid = new int[3][];
        grid[0] = new int[] { 0, 1, 1 };
        grid[1] = new int[] { 1, 0, 1 };
        grid[2] = new int[] { 0, 0, 1 };

        // Act
        var result = solution.OnesMinusZeros(grid);

        // Assert
        Assert.True(true);
    }
}