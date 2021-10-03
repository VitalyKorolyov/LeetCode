using LeetCode.Array.Easy.MoveZeroes;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.MoveZeroes
{
    public class SolutionTests
    {
        [Fact]
        public void MoveZeroes_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = {0,1,0,3,12};

            // Act
            solution.MoveZeroes(nums);

            // Assert
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, nums);
        }
    }
}
