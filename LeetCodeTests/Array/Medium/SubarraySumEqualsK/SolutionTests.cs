using LeetCode.Array.Medium.SubarraySumEqualsK;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.SubarraySumEqualsK
{
    public class SolutionTests
    {
        [Fact]
        public void SubarraySum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = { 1, 2, 3 };
            int k = 3;

            // Act
            var result = solution.SubarraySum(
                nums,
                k);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
