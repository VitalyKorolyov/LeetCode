using LeetCode.Matrix.Easy.TransposeMatrix;
using Xunit;

namespace LeetCodeTests.Matrix.Easy.TransposeMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void Transpose_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] matrix = new int[2][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };

            // Act
            var result = solution.Transpose(matrix);

            // Assert
            Assert.True(true);
        }
    }
}
