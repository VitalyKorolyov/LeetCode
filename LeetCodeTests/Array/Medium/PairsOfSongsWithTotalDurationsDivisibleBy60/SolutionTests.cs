using LeetCode.Array.Medium.PairsOfSongsWithTotalDurationsDivisibleBy60;
using Xunit;

namespace LeetCodeTests.Array.Medium.PairsOfSongsWithTotalDurationsDivisibleBy60
{
    public class SolutionTests
    {
        [Fact]
        public void NumPairsDivisibleBy60_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] time = new int[] { 60, 60, 60 };

            // Act
            var result = solution.NumPairsDivisibleBy60(time);

            // Assert
            Assert.True(3 == result);
        }
    }
}
