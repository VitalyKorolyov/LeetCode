using LeetCode.Math.Easy.ArmstrongNumber;
using System;
using Xunit;

namespace LeetCodeTests.Math.Easy.ArmstrongNumber
{
    public class SolutionTests
    {
        [Fact]
        public void IsArmstrong_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 153;

            // Act
            var result = solution.IsArmstrong(
                n);

            // Assert
            Assert.True(result);
        }
    }
}
