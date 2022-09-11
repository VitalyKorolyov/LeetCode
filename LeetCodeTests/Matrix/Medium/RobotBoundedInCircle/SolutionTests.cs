using LeetCode.Matrix.Medium.RobotBoundedInCircle;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.RobotBoundedInCircle
{
    public class SolutionTests
    {
        [Fact]
        public void IsRobotBounded_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string instructions = "GGLLGG";

            // Act
            var result = solution.IsRobotBounded(
                instructions);

            // Assert
            Assert.True(!result);
        }
    }
}
