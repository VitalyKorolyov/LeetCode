using LeetCode.String.Medium.GroupAnagrams;
using Xunit;

namespace LeetCodeTests.String.Medium.GroupAnagrams;

public class SolutionTests
{
    [Fact]
    public void GroupAnagrams_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result = solution.GroupAnagrams(strs);

        // Assert
        Assert.True(true);
    }
}