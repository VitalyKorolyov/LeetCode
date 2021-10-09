using LeetCode.String.Medium.ReverseWordsInAString;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.ReverseWordsInAString
{
    public class SolutionTests
    {
        [Fact]
        public void ReverseWords_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s =
                "F R  I   E    N     D      S      ";

            // Act
            var result = solution.ReverseWords(
                s);

            // Assert
            Assert.Equal(
                "S D N E I R F", result);
        }
    }
}
