using LeetCode.Array.Medium.MaximumPointsYouCanObtainFromCards;
using Xunit;

namespace LeetCodeTests.Array.Medium.MaximumPointsYouCanObtainFromCards;

public class SolutionTests
{
    [Fact]
    public void MaxScore_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] cardPoints = new int[] { 1, 2, 3, 4, 5, 6, 1 };
        int k = 3;

        // Act
        var result = solution.MaxScore(cardPoints, k);

        // Assert
        Assert.Equal(12, result);
    }
}