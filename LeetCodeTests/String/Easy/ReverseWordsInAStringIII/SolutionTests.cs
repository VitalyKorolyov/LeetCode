using LeetCode.String.Easy.ReverseWordsInAStringIII;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.ReverseWordsInAStringIII
{
    public class SolutionTests
    {
        [Fact]
        public void ReverseWords_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string s = "s'teL ekat edoCteeL tsetnoc";

            // Act
            var result = Solution.ReverseWords(
                s);

            // Assert
            Assert.Equal("Let's take LeetCode contest", result);
        }
    }
}
