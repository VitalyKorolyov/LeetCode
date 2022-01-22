using LeetCode.String.Medium.ValidPalindromeII;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.ValidPalindromeII
{
    public class SolutionTests
    {
        [Fact]
        public void ValidPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "abckmkdcba";

            // Act
            var result = solution.ValidPalindrome(
                s);

            // Assert
            Assert.True(result);
        }
    }
}
