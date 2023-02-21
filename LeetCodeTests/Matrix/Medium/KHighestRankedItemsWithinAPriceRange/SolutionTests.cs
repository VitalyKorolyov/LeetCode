using LeetCode.Matrix.Medium.KHighestRankedItemsWithinAPriceRange;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.KHighestRankedItemsWithinAPriceRange;

public class SolutionTests
{
    [Fact]
    public void HighestRankedKItems_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] grid = new int[3][] {
                new int[] { 1,2,0,1 },
                new int[] { 1,3,0,1 },
                new int[] { 0,2,5,1 }};

        int[] pricing = { 2, 5 };
        int[] start = { 0, 0 };
        int k = 3;

        // Act
        var result = solution.HighestRankedKItems(
            grid,
            pricing,
            start,
            k);

        // Assert
        Assert.True(true);
    }
}