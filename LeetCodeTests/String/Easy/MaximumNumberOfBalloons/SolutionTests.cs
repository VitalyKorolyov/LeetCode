using LeetCode.String.Easy.MaximumNumberOfBalloons;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.MaximumNumberOfBalloons
{
    public class SolutionTests
    {
        [Fact]
        public void MaxNumberOfBalloons_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string text = "balllllllllllloooooooooon";

            // Act
            var result = solution.MaxNumberOfBalloons(
                text);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
