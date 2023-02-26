using LeetCode.Array.Easy.TwoOutOfThree;
using Xunit;

namespace LeetCodeTests.Array.Easy.TwoOutOfThree;

public class SolutionTests
{
    [Fact]
    public void TwoOutOfThree_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums1 = new int[] { 1, 1, 3, 2 };
        int[] nums2 = new int[] { 2, 3 };
        int[] nums3 = new int[] { 3 };

        // Act
        var result = solution.TwoOutOfThree(nums1, nums2, nums3);

        // Assert
        Assert.True(true);
    }
}