using LeetCode.Array.Medium.LongestRepeatingCharacterReplacement;
using Xunit;

namespace LeetCodeTests.Array.Medium.LongestRepeatingCharacterReplacement
{
    public class SolutionTests
    {
        [Fact]
        public void CharacterReplacement_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "AABABBA";
            int k = 1;

            // Act
            var result = solution.CharacterReplacement(
                s,
                k);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
