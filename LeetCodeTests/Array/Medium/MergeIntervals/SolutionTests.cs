using LeetCode.Array.Medium.MergeIntervals;
using Xunit;

namespace LeetCodeTests.Array.Medium.MergeIntervals;

public class SolutionTests
{
    [Fact]
    public void Merge_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] intervals = new[] 
        { 
            new int[] { 1, 3 }, 
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 },
        };

        // Act
        var result = solution.Merge(intervals);

        // Assert
        Assert.True(true);
    }
}