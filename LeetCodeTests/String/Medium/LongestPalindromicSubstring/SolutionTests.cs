using LeetCode.String.Medium.LongestPalindromicSubstring;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.LongestPalindromicSubstring
{
    public class SolutionTests
    {
        [Fact]
        public void LongestPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "babad";

            // Act
            var result = solution.LongestPalindrome(s);

            // Assert
            Assert.Equal("aba", result);
        }
    }
}
