using LeetCode.Array.Medium.Subsets;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.Subsets
{
    public class SolutionTests
    {
        [Fact]
        public void Subsets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 1, 2, 3 };

            // Act
            var result = solution.Subsets(nums);

            // Assert
            Assert.True(true);
        }
    }
}
