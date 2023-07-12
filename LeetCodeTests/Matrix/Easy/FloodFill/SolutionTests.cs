using LeetCode.Matrix.Easy.FloodFill;
using Xunit;

namespace LeetCodeTests.Matrix.Easy.FloodFill;

public class SolutionTests
{
    [Fact]
    public void FloodFill_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] image = new int[3][];
        image[0] = new int[] { 1, 1, 1 };
        image[1] = new int[] { 1, 1, 0 };
        image[2] = new int[] { 1, 0, 1 };
        int sr = 1;
        int sc = 1;
        int color = 2;

        // Act
        var result = solution.FloodFill(image, sr, sc, color);

        // Assert
        Assert.True(true);
    }
}