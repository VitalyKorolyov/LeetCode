using LeetCode.String.Easy.SortingTheSentence;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.SortingTheSentence
{
    public class SolutionTests
    {
        [Fact]
        public void SortSentence_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string s = "is2 sentence4 This1 a3";

            // Act
            var result = Solution.SortSentence(
                s);

            // Assert
            Assert.Equal("This is a sentence", result);
        }
    }
}
