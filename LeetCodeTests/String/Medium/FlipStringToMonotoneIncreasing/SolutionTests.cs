using LeetCode.String.Medium.FlipStringToMonotoneIncreasing;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.FlipStringToMonotoneIncreasing
{
    public class SolutionTests
    {
        [Fact]
        public void MinFlipsMonoIncr_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "00110";

            // Act
            var result = solution.MinFlipsMonoIncr(s);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
