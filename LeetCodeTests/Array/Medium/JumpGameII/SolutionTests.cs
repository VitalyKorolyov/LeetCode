using LeetCode.Array.Medium.JumpGameII;
using Xunit;

namespace LeetCodeTests.Array.Medium.JumpGameII;

public class SolutionTests
{
    [Fact]
    public void Jump_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 2, 3, 0, 1, 4 };

        // Act
        var result = solution.Jump(nums);

        // Assert
        Assert.True(result == 2);
    }
}