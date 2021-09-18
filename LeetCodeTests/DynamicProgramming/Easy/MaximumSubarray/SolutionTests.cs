using LeetCode.DynamicProgramming.Easy.MaximumSubarray;
using System;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Easy.MaximumSubarray
{
    public class SolutionTests
    {
        [Fact]
        public void MaxSubArray_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            // Act
            var result = solution.MaxSubArray(nums);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
