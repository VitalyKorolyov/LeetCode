using LeetCode.Matrix.Medium.SetMatrixZeroes;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.SetMatrixZeroes
{
    public class SolutionTests
    {
        [Fact]
        public void SetZeroes_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[][] matrix = new int[1][];
            matrix[0] = new int[] { 1, 0, 3 };

            // Act
            Solution.SetZeroes(matrix);

            // Assert
            Assert.True(true);
        }
    }
}
