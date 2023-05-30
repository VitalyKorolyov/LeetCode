using LeetCode.String.Easy.ValidParentheses;
using Xunit;

namespace LeetCodeTests.String.Easy.ValidParentheses;

public class SolutionTests
{
    [Fact]
    public void IsValidStack_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "([])";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.True(result);
    }
}