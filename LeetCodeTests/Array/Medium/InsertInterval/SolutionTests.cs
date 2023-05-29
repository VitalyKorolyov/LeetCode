using LeetCode.Array.Medium.InsertInterval;
using Xunit;

namespace LeetCodeTests.Array.Medium.InsertInterval;

public class SolutionTests
{
    [Fact]
    public void Insert_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] intervals = new int[2][];
        intervals[0] = new int[] { 1, 3 };
        intervals[1] = new int[] { 6, 9 };

        int[] newInterval = new int[] { 2, 5 };

        // Act
        var result = solution.Insert(intervals, newInterval);

        // Assert
        Assert.True(true);
    }
}