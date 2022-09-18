using LeetCode.String.Medium.MinimumNumberOfKeypresses;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumNumberOfKeypresses
{
    public class SolutionTests
    {
        [Fact]
        public void MinimumKeypresses_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "abcdefghijkl";

            // Act
            var result = solution.MinimumKeypresses(s);

            // Assert
            Assert.True(result == 15);
        }
    }
}
