using LeetCode.Graph.Medium.CheapestFlightsWithinKStops;
using Xunit;

namespace LeetCodeTests.Graph.Medium.CheapestFlightsWithinKStops;

public class SolutionTests
{
    [Fact]
    public void FindCheapestPrice_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int n = 3;
        int[][] flights = new int[][]
        {
            new int[]{ 0,1,100 },
            new int[]{ 1,2,100 },
            new int[]{ 0,2,500 },
        };
        int src = 0;
        int dst = 2;
        int k = 1;

        // Act
        var result = solution.FindCheapestPrice(n, flights, src, dst, k);

        // Assert
        Assert.True(result == 200);
    }
}