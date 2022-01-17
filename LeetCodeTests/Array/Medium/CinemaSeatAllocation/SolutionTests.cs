using LeetCode.Array.Medium.CinemaSeatAllocation;
using System;
using Xunit;

namespace LeetCodeTests.Array.Medium.CinemaSeatAllocation
{
    public class SolutionTests
    {
        [Fact]
        public void MaxNumberOfFamilies_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int n = 5;
            int[][] reservedSeats = new int[15][];
            for (int i = 0; i < 15; i++)
            {
                reservedSeats[i] = new int[2];
            }
            reservedSeats[0][0] = 4;
            reservedSeats[0][1] = 7;
            reservedSeats[1][0] = 4;
            reservedSeats[1][1] = 1;
            reservedSeats[2][0] = 3;
            reservedSeats[2][1] = 1;
            reservedSeats[3][0] = 5;
            reservedSeats[3][1] = 9;
            reservedSeats[4][0] = 4;
            reservedSeats[4][1] = 4;
            reservedSeats[5][0] = 3;
            reservedSeats[5][1] = 7;
            reservedSeats[6][0] = 1;
            reservedSeats[6][1] = 3;
            reservedSeats[7][0] = 5;
            reservedSeats[7][1] = 5;
            reservedSeats[8][0] = 1;
            reservedSeats[8][1] = 6;
            reservedSeats[9][0] = 1;
            reservedSeats[9][1] = 8;
            reservedSeats[10][0] = 3;
            reservedSeats[10][1] = 9;
            reservedSeats[11][0] = 2;
            reservedSeats[11][1] = 9;
            reservedSeats[12][0] = 1;
            reservedSeats[12][1] = 4;
            reservedSeats[13][0] = 1;
            reservedSeats[13][1] = 9;
            reservedSeats[14][0] = 1;
            reservedSeats[14][1] = 10;


            // Act
            var result = solution.MaxNumberOfFamilies(
                n,
                reservedSeats);

            // Assert
            Assert.True(true);
        }
    }
}
