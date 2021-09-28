using LeetCode.DynamicProgramming.Easy.CountingBits;
using System;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Easy.CountingBits
{
    public class SolutionTests
    {
        [Fact]
        public void CountBits_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 3;

            // Act
            var result = solution.CountBits(
                n);

            // Assert
            Assert.True(true);
        }
    }
}
