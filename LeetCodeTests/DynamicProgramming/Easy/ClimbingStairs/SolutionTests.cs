using LeetCode.DynamicProgramming.Easy.ClimbingStairs;
using System;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Easy.ClimbingStairs
{
    public class SolutionTests
    {
        [Fact]
        public void ClimbStairs_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 5;

            // Act
            var result = solution.ClimbStairs(
                n);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
