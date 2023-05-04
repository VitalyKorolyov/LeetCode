using LeetCode.Array.Medium.RandomPickWithWeight;
using Xunit;

namespace LeetCodeTests.Array.Medium.RandomPickWithWeight;

public class SolutionTests
{
    [Fact]
    public void PickIndex_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution(new int[] { 1, 3 });

        // Act
        var result = solution.PickIndex();

        // Assert
        Assert.True(true);
    }
}