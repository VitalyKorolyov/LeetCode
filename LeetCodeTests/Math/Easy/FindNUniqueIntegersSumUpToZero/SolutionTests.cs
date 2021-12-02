using LeetCode.Math.Easy.FindNUniqueIntegersSumUpToZero;
using System;
using System.Linq;
using Xunit;

namespace LeetCodeTests.Math.Easy.FindNUniqueIntegersSumUpToZero
{
    public class SolutionTests
    {
        [Fact]
        public void SumZero_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 1;

            // Act
            var result = solution.SumZero(n);

            // Assert
            Assert.True(result.Sum() == 0);
        }
    }
}
