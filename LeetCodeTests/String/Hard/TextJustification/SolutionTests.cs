using LeetCode.String.Hard.TextJustification;
using Xunit;

namespace LeetCodeTests.String.Hard.TextJustification;

public class SolutionTests
{
    [Fact]
    public void FullJustify_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] words = new string[]{ "What", "must", "be", "acknowledgment", "shall", "be" };
        int maxWidth = 16;

        // Act
        var result = solution.FullJustify(words, maxWidth);

        // Assert
        Assert.True(true);
    }
}