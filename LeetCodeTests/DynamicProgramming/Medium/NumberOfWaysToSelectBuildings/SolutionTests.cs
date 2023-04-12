using LeetCode.DynamicProgramming.Medium.NumberOfWaysToSelectBuildings;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.NumberOfWaysToSelectBuildings;

public class SolutionTests
{
    [Fact]
    public void NumberOfWays_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.NumberOfWays("001101");

        // Assert
        Assert.True(6 == result);
    }
}