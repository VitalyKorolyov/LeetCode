using LeetCode.Matrix.Easy.CheckifEveryRowAndColumnContainsAllNumbers;
using Xunit;

namespace LeetCodeTests.Matrix.Easy.CheckifEveryRowAndColumnContainsAllNumbers
{
    public class SolutionTests
    {
        [Fact]
        public void CheckValid_StateUnderTest_ExpectedBehavior()
        {
            // Arrange [[1,2,3],[3,1,2],[2,3,1]]
            var solution = new Solution();
            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 3, 1, 2 };
            matrix[2] = new int[3] { 2, 3, 1 };

            // Act
            var result = solution.CheckValid(matrix);

            // Assert
            Assert.True(result);
        }
    }
}
