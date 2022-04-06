using LeetCode.Array.Medium.SumOfSubarrayMinimums;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.SumOfSubarrayMinimums
{
    public class SolutionTests
    {
        [Fact]
        public void SumSubarrayMins_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] arr = {11, 81, 94, 43, 3};

            // Act
            var result = solution.SumSubarrayMins(arr);

            // Assert
            Assert.Equal(444, result);
        }
    }
}
