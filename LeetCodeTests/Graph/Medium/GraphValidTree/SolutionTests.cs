using LeetCode.Graph.Medium.GraphValidTree;
using Xunit;

namespace LeetCodeTests.Graph.Medium.GraphValidTree;

public class SolutionTests
{
    [Fact]
    public void ValidTree_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int n = 5;
        int[][] edges = new int[4][];
        edges[0] = new int[] { 0, 1 };
        edges[1] = new int[] { 0, 2 };
        edges[2] = new int[] { 0, 3 };
        edges[3] = new int[] { 1, 4 };

        // Act
        var result = solution.ValidTree(n, edges);

        // Assert
        Assert.True(result);
    }
}