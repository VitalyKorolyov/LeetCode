using LeetCode.Array.Easy.SingleNumber;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.SingleNumber
{
    public class SolutionTests
    {
        [Fact]
        public void SingleNumber_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {4, 1, 2, 1, 2};

            // Act
            var result = solution.SingleNumber(nums);

            // Assert
            Assert.True(result == 4);
        }
    }
}
