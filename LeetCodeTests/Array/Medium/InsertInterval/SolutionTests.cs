using LeetCode.Array.Medium.InsertInterval;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.InsertInterval
{
    public class SolutionTests
    {
        [Fact]
        public void Insert_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] intervals = new int[1][];
            intervals[0] = new int[] { 1, 5};
            int[] newInterval = new int[] {6, 8};

            // Act
            var result = solution.Insert(
                intervals,
                newInterval);

            // Assert
            Assert.True(true);
        }
    }
}
