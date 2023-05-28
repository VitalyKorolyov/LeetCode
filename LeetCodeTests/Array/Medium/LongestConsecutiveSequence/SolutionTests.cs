using LeetCode.Array.Medium.LongestConsecutiveSequence;
using Xunit;

namespace LeetCodeTests.Array.Medium.LongestConsecutiveSequence;

public class SolutionTests
{
    [Fact]
    public void LongestConsecutive_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

        // Act
        var result = solution.LongestConsecutive(nums);

        // Assert
        Assert.True(result == 4);
    }
}