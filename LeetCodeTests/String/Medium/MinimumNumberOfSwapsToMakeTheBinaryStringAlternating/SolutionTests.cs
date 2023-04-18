using LeetCode.String.Medium.MinimumNumberOfSwapsToMakeTheBinaryStringAlternating;
using Xunit;

namespace LeetCodeTests.String.Medium.MinimumNumberOfSwapsToMakeTheBinaryStringAlternating;

public class SolutionTests
{
    [Fact]
    public void MinSwaps_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "111000";

        // Act
        var result = solution.MinSwaps(s);

        // Assert
        Assert.True(result == 1);
    }
}
