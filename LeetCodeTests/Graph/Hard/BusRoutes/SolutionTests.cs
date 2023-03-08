using LeetCode.Graph.Hard.BusRoutes;
using Xunit;

namespace LeetCodeTests.Graph.Hard.BusRoutes;

public class SolutionTests
{
    [Fact]
    public void NumBusesToDestination_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] routes = new int[][] { new int[] { 1, 2, 7 }, new int[] { 3, 6, 7 } };
        int source = 1;
        int target = 6;

        // Act
        var result = solution.NumBusesToDestination(routes, source, target);

        // Assert
        Assert.True(result == 2);
    }
}