using LeetCode.Math.Medium.NumberOfStepsToReduceANumberInBinaryRepresentationToOne;
using System;
using Xunit;

namespace LeetCodeTests.Math.Medium.NumberOfStepsToReduceANumberInBinaryRepresentationToOne
{
    public class SolutionTests
    {
        [Fact]
        public void NumSteps_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "10101";

            // Act
            var result = solution.NumSteps(
                s);

            // Assert
            Assert.True(result == 8);
        }
    }
}
