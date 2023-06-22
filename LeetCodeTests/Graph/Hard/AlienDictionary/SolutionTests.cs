using LeetCode.Graph.Hard.AlienDictionary;
using Xunit;

namespace LeetCodeTests.Graph.Hard.AlienDictionary;

public class SolutionTests
{
    [Fact]
    public void AlienOrder_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] words = { "abc", "ab" };

        // Act
        var result = solution.AlienOrder(words);

        // Assert
        Assert.True(result == "");
    }
}