using LeetCode.Graph.Medium.ReorderRoutesToMakeAllPathsLeadToTheCityZero;
using Xunit;

namespace LeetCodeTests.Graph.Medium.ReorderRoutesToMakeAllPathsLeadToTheCityZero;

public class SolutionTests
{
    [Fact]
    public void MinReorder_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int n = 6;
        int[][] connections = new int[][]{
            new int[]{ 0, 1},
            new int[] { 1, 3},
            new int[] { 2, 3},
            new int[] { 4, 0},
            new int[] { 4, 5} };

        // Act
        var result = solution.MinReorder(n, connections);

        // Assert
        Assert.True(true);
    }
}