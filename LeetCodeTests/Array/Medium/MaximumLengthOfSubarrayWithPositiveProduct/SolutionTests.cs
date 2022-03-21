using LeetCode.Array.Medium.MaximumLengthOfSubarrayWithPositiveProduct;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.MaximumLengthOfSubarrayWithPositiveProduct
{
    public class SolutionTests
    {
        [Fact]
        public void GetMaxLen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = {1000000000,1000000000};

            // Act
            var result = solution.GetMaxLen(nums);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
