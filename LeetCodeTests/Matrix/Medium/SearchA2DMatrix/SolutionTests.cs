using LeetCode.Matrix.Medium.SearchA2DMatrix;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.SearchA2DMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void SearchMatrix_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 2, 5, 6 };
            matrix[1] = new int[] { 7, 10, 12 };
            matrix[2] = new int[] { 15, 16, 20 };

            int target = 11;

            // Act
            var result = solution.SearchMatrix(matrix, target);

            // Assert
            Assert.False(result);
        }
    }
}
