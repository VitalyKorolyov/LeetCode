using LeetCode.Matrix.Easy;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Easy.FindWinnerOnATicTacToeGame
{
    public class SolutionTests
    {
        [Fact]
        public void Tictactoe_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] moves = new int[2][];
            moves[0] = new[] { 0, 0 };
            moves[1] = new[] { 1, 1 };
            //moves[2] = new[] { 1, 1 };
            //moves[3] = new[] { 2, 1 };
            //moves[4] = new[] { 2, 2 };

            // Act
            var result = solution.Tictactoe(moves);

            // Assert
            Assert.True(false);
        }
    }
}
