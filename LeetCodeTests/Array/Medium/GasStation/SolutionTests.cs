using LeetCode.Array.Medium.GasStation;
using Xunit;

namespace LeetCodeTests.Array.Medium.GasStation;

public class SolutionTests
{
    [Fact]
    public void CanCompleteCircuit_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] gas = new int[] { 5, 8, 2, 8 };
        int[] cost = new int[] { 6, 5, 6, 6 };

        // Act
        var result = solution.CanCompleteCircuit(gas, cost);

        // Assert
        Assert.True(result == 3);
    }
}