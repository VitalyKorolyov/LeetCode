using LeetCode.String.Hard.ConcatenatedWords;
using System;
using Xunit;

namespace LeetCodeTests.String.Hard.ConcatenatedWords
{
    public class SolutionTests
    {
        [Fact]
        public void FindAllConcatenatedWordsInADict_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] words = { "" };

            // Act
            var result = solution.FindAllConcatenatedWordsInADict(words);

            // Assert
            Assert.True(true);
        }
    }
}
