using LeetCode.Array.Medium.KokoEatingBananas;
using Xunit;

namespace LeetCodeTests.Array.Medium.KokoEatingBananas;

public class SolutionTests
{
    [Fact]
    public void MinEatingSpeed_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] piles = { 312884470 };
        int h = 312884469;

        // Act
        var result = solution.MinEatingSpeed(piles, h);

        // Assert
        Assert.True(result == 2);
    }
}