using LeetCode.Array.Hard.WordLadderII;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Array.Hard.WordLadderII;

public class SolutionTests
{
    [Fact]
    public void FindLadders_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string beginWord = "hit";
        string endWord = "cog";
        List<string> wordList = new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" };

        // Act
        var result = solution.FindLadders(beginWord,
            endWord, wordList);

        // Assert
        Assert.Equal(2, result.Count);
    }
}