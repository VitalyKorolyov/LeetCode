using LeetCode.Matrix.Medium.SpiralMatrix;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.SpiralMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void SpiralOrder_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();

            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };


            // Act
            var result = solution.SpiralOrder(matrix);

            // Assert
            Assert.Equal(new[]{1, 2, 3, 6, 9, 8, 7, 4, 5}, result);
        }
    }
}
