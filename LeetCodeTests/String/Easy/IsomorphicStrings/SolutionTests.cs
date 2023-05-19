using LeetCode.String.Easy.IsomorphicStrings;
using Xunit;

namespace LeetCodeTests.String.Easy.IsomorphicStrings;

public class SolutionTests
{
    [Fact]
    public void IsIsomorphic_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "badc";
        string t = "baba";

        // Act
        var result = solution.IsIsomorphic(s, t);

        // Assert
        Assert.False(result);
    }
}