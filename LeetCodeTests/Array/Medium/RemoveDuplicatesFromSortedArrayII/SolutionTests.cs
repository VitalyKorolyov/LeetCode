using LeetCode.Array.Medium.RemoveDuplicatesFromSortedArrayII;
using Xunit;

namespace LeetCodeTests.Array.Medium.RemoveDuplicatesFromSortedArrayII;

public class SolutionTests
{
    [Fact]
    public void RemoveDuplicates_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        // Act
        var result = solution.RemoveDuplicates(nums);

        // Assert
        Assert.True(result == 7);
    }
}