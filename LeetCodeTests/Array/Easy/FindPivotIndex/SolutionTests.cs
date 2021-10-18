using LeetCode.Array.Easy.FindPivotIndex;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.FindPivotIndex
{
    public class SolutionTests
    {
        [Fact]
        public void PivotIndex_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new []{1, 7, 3, 6, 5, 6};

            // Act
            var result = solution.PivotIndex(nums);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
