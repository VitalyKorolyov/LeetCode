using LeetCode.Math.Medium;
using System;
using Xunit;

namespace LeetCodeTests.Math.Medium
{
    public class SolutionTests
    {
        [Fact]
        public void AngleClock_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int hour = 3;
            int minutes = 30;

            // Act
            var result = solution.AngleClock(
                hour,
                minutes);

            // Assert
            Assert.Equal(75, result);
        }
    }
}
