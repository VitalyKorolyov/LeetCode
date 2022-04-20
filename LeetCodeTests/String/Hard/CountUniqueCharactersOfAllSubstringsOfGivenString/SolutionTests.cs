using LeetCode.String.Hard.CountUniqueCharactersOfAllSubstringsOfGivenString;
using System;
using Xunit;

namespace LeetCodeTests.String.Hard.CountUniqueCharactersOfAllSubstringsOfGivenString
{
    public class SolutionTests
    {
        [Fact]
        public void UniqueLetterString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "LEETCODE";

            // Act
            var result = solution.UniqueLetterString(
                s);

            // Assert
            Assert.Equal(92, result);
        }
    }
}
