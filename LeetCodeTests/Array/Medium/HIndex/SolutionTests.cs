using LeetCode.Array.Medium.HIndex;
using Xunit;

namespace LeetCodeTests.Array.Medium.HIndex;

public class SolutionTests
{
    [Fact]
    public void HIndex_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] citations = { 1, 0 };

        // Act
        var result = solution.HIndex(citations);

        // Assert
        Assert.True(true);
    }
}
