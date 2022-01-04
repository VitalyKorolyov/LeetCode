using LeetCode.String.Medium.StringCompression;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.StringCompression
{
    public class SolutionTests
    {
        [Fact]
        public void Compress_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            char[] chars = {'c', 'c', 'c' , 'c', 'c', 'b' };

            // Act
            var result = solution.Compress(
                chars);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
