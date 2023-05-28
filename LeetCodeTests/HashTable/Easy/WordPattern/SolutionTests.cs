using LeetCode.HashTable.Easy.WordPattern;
using Xunit;

namespace LeetCodeTests.HashTable.Easy.WordPattern;

public class SolutionTests
{
    [Fact]
    public void WordPattern_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string pattern = "abba";
        string s = "dog cat cat fish";

        // Act
        var result = solution.WordPattern(pattern, s);

        // Assert
        Assert.False(result);
    }
}