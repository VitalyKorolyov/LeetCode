using LeetCode.Array.Medium.EqualSumArraysWithMinimumNumberOfOperations;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.EqualSumArraysWithMinimumNumberOfOperations
{
    public class SolutionTests
    {
        [Fact]
        public void MinOperations_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums1 = { 6, 6 };
            int[] nums2 = { 1 };

            // Act
            var result = solution.MinOperations(nums1, nums2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
