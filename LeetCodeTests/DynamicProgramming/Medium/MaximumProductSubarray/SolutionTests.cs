using LeetCode.DynamicProgramming.Medium.MaximumProductSubarray;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.MaximumProductSubarray;

public class SolutionTests
{
    [Fact]
    public void MaxProduct_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 2, 1, 1, -2 };

        // Act
        var result = solution.MaxProduct(nums);

        // Assert
        Assert.Equal(1, result);
    }
}
