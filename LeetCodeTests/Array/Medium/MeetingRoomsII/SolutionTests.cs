using LeetCode.Array.Medium.MeetingRoomsII;
using Xunit;

namespace LeetCodeTests.Array.Medium.MeetingRoomsII;

public class SolutionTests
{
    [Fact]
    public void MinMeetingRooms_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[][] intervals = {
            new[] { 1, 10 },
            new[] { 2, 7 },
            new[] { 3, 19 },
            new[] { 8, 12 },
            new[] { 10, 20 },
            new[] { 11, 30 } 
        };

        // Act
        var result = solution.MinMeetingRooms(intervals);

        // Assert
        Assert.Equal(4, result);
    }
}