using LeetCode.Math.Easy.HappyNumber;
using System;
using Xunit;

namespace LeetCodeTests.Math.Easy.HappyNumber
{
    public class SolutionTests
    {
        [Fact]
        public void IsHappy_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 19;

            // Act
            var result = solution.IsHappy(n);

            // Assert
            Assert.True(result);
        }
    }
}
