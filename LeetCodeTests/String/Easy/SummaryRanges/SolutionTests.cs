using LeetCode.String.Easy.SummaryRanges;
using Xunit;

namespace LeetCodeTests.String.Easy.SummaryRanges;

public class SolutionTests
{
    [Fact]
    public void SummaryRanges_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = { 0, 1, 2, 4, 5, 7 };

        // Act
        var result = solution.SummaryRanges(nums);

        // Assert
        Assert.Equal(result, new string[] { "0->2","4->5","7" });

        // Arrange
        nums = new int[] { 0,2,3,4,6,8,9 };

        // Act
        result = solution.SummaryRanges(nums);

        // Assert
        Assert.Equal(result, new string[] { "0", "2->4", "6", "8->9" });
    }
}