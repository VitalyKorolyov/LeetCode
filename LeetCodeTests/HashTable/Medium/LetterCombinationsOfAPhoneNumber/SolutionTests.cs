using LeetCode.HashTable.Medium.LetterCombinationsOfAPhoneNumber;
using System;
using System.Linq;
using Xunit;

namespace LeetCodeTests.HashTable.Medium.LetterCombinationsOfAPhoneNumber
{
    public class SolutionTests
    {
        [Fact]
        public void LetterCombinations_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string digits = "234";

            // Act
            var result = solution.LetterCombinations(
                digits);

            // Assert
            Assert.Equal(new[]{"adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"}, result);
        }
    }
}
