using LeetCode.Array.Medium.MergeIntervals;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.MergeIntervals
{
    public class SolutionTests
    {
        [Fact]
        public void Merge_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] intervals = new[] {new int[] {1, 4}, new int[] {0, 1} };

            // Act
            var result = solution.Merge(
                intervals);

            // Assert
            Assert.True(true);
        }
    }
}
