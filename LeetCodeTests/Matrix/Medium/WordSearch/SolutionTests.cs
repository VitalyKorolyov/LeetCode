using LeetCode.Matrix.Medium.WordSearch;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.WordSearch
{
    public class SolutionTests
    {
        [Fact]
        public void Exist_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            char[][] board = new char[4][];
            board[0] = new char[]{'E', 'C', 'B', 'F'}; 
            board[1] = new char[]{'D', 'M', 'K', 'Y'}; 
            board[2] = new char[]{'K', 'C', 'B', 'D'}; 
            board[3] = new char[]{'O', 'Y', 'K', 'M'}; 

            string word = "MKBK";

            // Act
            var result = solution.Exist(board, word);

            // Assert
            Assert.True(result);
        }
    }
}
