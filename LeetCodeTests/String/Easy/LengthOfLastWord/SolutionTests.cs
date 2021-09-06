using LeetCode.String.Easy.LengthOfLastWord;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.LengthOfLastWord
{
    public class SolutionTests
    {
        [Fact]
        public void LengthOfLastWord_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "f";

            // Act
            var result = solution.LengthOfLastWord(
                s);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
