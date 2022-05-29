using LeetCode.String.Easy.AddStrings;
using Xunit;

namespace LeetCodeTests.String.Easy.AddStrings
{
    public class SolutionTests
    {
        [Fact]
        public void AddStrings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.AddStrings("6994", "36");

            // Assert
            Assert.Equal("134", result);
        }
    }
}
