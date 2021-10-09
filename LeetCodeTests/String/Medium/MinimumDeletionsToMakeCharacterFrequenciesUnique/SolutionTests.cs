using LeetCode.String.Medium.MinimumDeletionsToMakeCharacterFrequenciesUnique;
using System;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    public class SolutionTests
    {
        [Fact]
        public void MinDeletions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "bbcebab";

            // Act
            var result = solution.MinDeletions(s);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
