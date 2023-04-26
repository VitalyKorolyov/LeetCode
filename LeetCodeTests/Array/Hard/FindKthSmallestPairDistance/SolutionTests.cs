using LeetCode.Array.Hard.FindKthSmallestPairDistance;
using Xunit;

namespace LeetCodeTests.Array.Hard.FindKthSmallestPairDistance;

public class SolutionTests
{
    [Fact]
    public void SplitArray_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = { 1, 6, 1, 3 };
        int k = 3;

        // Act
        var result = solution.SmallestDistancePair(nums, k);

        // Assert
        Assert.True(result == 2);
    }
}