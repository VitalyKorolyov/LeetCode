using LeetCode.Array.Medium.KthLargestElementInAnArray;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.KthLargestElementInAnArray
{
    public class SolutionTests
    {
        [Fact]
        public void FindKthLargest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k = 4;

            // Act
            var result = solution.FindKthLargest(
                nums,
                k);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
