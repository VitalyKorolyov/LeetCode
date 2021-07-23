using LeetCode.Array.Easy.GoalParserInterpretation;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.GoalParserInterpretation
{
    public class SolutionTests
    {
        [Fact]
        public void Interpret_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string command = "G()(al)";

            // Act
            var result = Solution.Interpret(command);

            // Assert
            Assert.Equal("Goal", result);
        }
    }
}
