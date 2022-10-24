using LeetCode.Array.Medium.FindMinimumInRotatedSortedArray;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.FindMinimumInRotatedSortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void FindMin_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 0, 1 };

            // Act
            var result = solution.FindMin(nums);

            // Assert
            Assert.True(result == 0);
        }
    }
}
