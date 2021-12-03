using LeetCode.String.Easy.ReverseVowelsOfAString;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.ReverseVowelsOfAString
{
    public class SolutionTests
    {
        [Fact]
        public void ReverseVowels_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "ai";

            // Act
            var result = solution.ReverseVowels(s);

            // Assert
            Assert.Equal("ia", result);
        }
    }
}
