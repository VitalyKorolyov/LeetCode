using LeetCode.String.Hard.WordBreakII;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.String.Hard.WordBreakII;

public class SolutionTests
{
    [Fact]
    public void WordBreak_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "catsanddog";
        List<string> wordDict = new List<string> { "cat", "cats", "and", "sand", "dog" };

        // Act
        var result = solution.WordBreak(s, wordDict);

        // Assert
        Assert.True(result.Count == 2);
        Assert.True(result[0] == "cat sand dog");
        Assert.True(result[1] == "cats and dog");
    }
}