using LeetCode.String.Easy.CheckIfAllCharactersHaveEqualNumberOfOccurrences;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    public class SolutionTests
    {
        [Fact]
        public void AreOccurrencesEqual_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "abacbc";

            // Act
            var result = solution.AreOccurrencesEqual(s);

            // Assert
            Assert.True(result);
        }
    }
}
