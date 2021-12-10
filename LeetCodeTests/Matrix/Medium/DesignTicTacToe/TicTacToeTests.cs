using LeetCode.Matrix.Medium.DesignTicTacToe;
using System;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.DesignTicTacToe
{
    public class TicTacToeTests
    {
        [Fact]
        public void Move_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var ticTacToe = new TicTacToe(4);

            // Act
            var result = ticTacToe.Move(
                2,
                0,
                1);

            result = ticTacToe.Move(
                2,
                1,
                1);


            result = ticTacToe.Move(
                2,
                2,
                1);


            result = ticTacToe.Move(
                2,
                3,
                1);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
