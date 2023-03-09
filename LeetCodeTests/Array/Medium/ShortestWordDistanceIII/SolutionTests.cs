using LeetCode.Array.Medium.ShortestWordDistanceIII;
using Xunit;

namespace LeetCodeTests.Array.Medium.ShortestWordDistanceIII;
public class SolutionTests
{
    [Fact]
    public void ShortestWordDistance_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] wordsDict = new string[] { "practice", "makes", "perfect", "coding", "makes" };
        string word1 = "makes";
        string word2 = "coding";

        // Act
        var result = solution.ShortestWordDistance(
            wordsDict,
            word1,
            word2);

        // Assert
        Assert.True(result == 1);
    }
}