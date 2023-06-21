using LeetCode.Graph.Medium.TopologicalSort;
using System;
using Xunit;

namespace LeetCodeTests.Graph.Medium.TopologicalSort;

public class SolutionTests
{
    [Fact]
    public void Sort_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int vertices = 4;
        int[][] edges = new int[][] {
            new int[] { 4, 2 }, new int[] { 4, 3 }, new int[] { 2, 1 }, new int[] { 3, 1 } };

        // Act
        var result = solution.Sort(vertices, edges);

        // Assert
        Assert.True(true);
    }
}