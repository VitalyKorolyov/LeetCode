using LeetCode.Array.Medium.SortAnArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.SortAnArray;

public class SolutionTests
{
    [Fact]
    public void SortArray_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 5, 1, 1, 2, 0, 0 };

        // Act
        var result = solution.SortArray(nums);

        // Assert
        Assert.Equal(new int[] { 0, 0, 1, 1, 2, 5 }, result);
    }
}