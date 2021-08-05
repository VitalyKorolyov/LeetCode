using LeetCode.Math.Easy.SelfDividingNumbers;
using System;
using Xunit;

namespace LeetCodeTests.Math.Easy.SelfDividingNumbers
{
    public class SolutionTests
    {
        [Fact]
        public void SelfDividingNumbers_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int left = 1;
            int right = 22;

            // Act
            var result = Solution.SelfDividingNumbers(
                left,
                right);

            // Assert
            Assert.True(false);
        }
    }
}
