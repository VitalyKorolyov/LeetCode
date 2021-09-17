using LeetCode.Math.Easy.FibonacciNumber;
using System;
using Xunit;

namespace LeetCodeTests.Math.Easy.FibonacciNumber
{
    public class SolutionTests
    {
        [Fact]
        public void Fib_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 4;

            // Act
            var result = solution.Fib(n);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
