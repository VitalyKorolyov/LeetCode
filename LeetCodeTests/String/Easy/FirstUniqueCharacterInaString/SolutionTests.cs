using LeetCode.String.Easy.FirstUniqueCharacterInaString;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.FirstUniqueCharacterInaString
{
    public class SolutionTests
    {
        [Fact]
        public void FirstUniqChar_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "leetcodez";

            // Act
            var result = solution.FirstUniqChar(s);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
