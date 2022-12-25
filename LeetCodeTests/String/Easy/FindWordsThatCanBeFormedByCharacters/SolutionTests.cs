using LeetCode.String.Easy.FindWordsThatCanBeFormedByCharacters;
using Xunit;

namespace LeetCodeTests.String.Easy.FindWordsThatCanBeFormedByCharacters
{
    public class SolutionTests
    {
        [Fact]
        public void CountCharacters_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string[] words = new string[] { "cat", "bt", "hat", "tree" };
            string chars = "atach";

            // Act
            var result = solution.CountCharacters(words, chars);

            // Assert
            Assert.True(result == 6);
        }
    }
}
