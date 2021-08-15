using LeetCode.Array.Easy.FindSmallestLetterGreaterThanTarget;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.FindSmallestLetterGreaterThanTarget
{
    public class SolutionTests
    {
        [Fact]
        public void NextGreatestLetter_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            char[] letters = { 'c', 'f', 'j' };
            char target = 'd';

            // Act
            var result = Solution.NextGreatestLetter(
                letters,
                target);

            // Assert
            Assert.Equal('f', result);
        }
    }
}
