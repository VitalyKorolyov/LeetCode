using LeetCode.String.Medium.WordBreak;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.String.Medium.WordBreak
{
    public class SolutionTests
    {
        [Fact]
        public void WordBreak_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "leetcode";
            var wordDict = new List<string> { "leet", "code" };

            // Act
            var result = solution.WordBreak(s, wordDict);

            // Assert
            Assert.True(result);
        }
    }
}
