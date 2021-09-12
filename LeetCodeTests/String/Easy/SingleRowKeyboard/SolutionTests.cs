using LeetCode.String.Easy.SingleRowKeyboard;
using System;
using Xunit;

namespace LeetCodeTests.String.Easy.SingleRowKeyboard
{
    public class SolutionTests
    {
        [Fact]
        public void CalculateTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string keyboard = "pqrstuvwxyzabcdefghijklmno";
            string word = "leetcode";

            // Act
            var result = solution.CalculateTime(
                keyboard,
                word);

            // Assert
            Assert.Equal(73, result);
        }
    }
}
