using LeetCode.Stack.Medium.CarFleet;
using Xunit;

namespace LeetCodeTests.Stack.Medium.CarFleet;

public class SolutionTests
{
    [Fact]
    public void CarFleet_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int target = 10;
        int[] position = { 6, 8 };
        int[] speed = { 3, 2 };

        // Act
        var result = solution.CarFleet(target, position, speed);

        // Assert
        Assert.True(result == 2);
    }
}