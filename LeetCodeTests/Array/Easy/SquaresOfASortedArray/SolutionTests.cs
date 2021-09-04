using LeetCode.Array.Easy.SquaresOfASortedArray;
using System;
using Xunit;

namespace LeetCodeTests.Array.Easy.SquaresOfASortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void SortedSquares_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = { -5,-3,-2,-1};

            // Act
            var result = Solution.SortedSquares(nums);

            // Assert
            Assert.Equal(new[] {1, 4, 9, 25}, result);
        }
    }
}
