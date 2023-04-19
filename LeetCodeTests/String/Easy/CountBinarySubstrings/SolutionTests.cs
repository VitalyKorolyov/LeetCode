using LeetCode.String.Easy.CountBinarySubstrings;
using Xunit;

namespace LeetCodeTests.String.Easy.CountBinarySubstrings;

public class SolutionTests
{
    [Fact]
    public void CountBinarySubstrings_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "10101";

        // Act
        var result = solution.CountBinarySubstrings(s);

        // Assert
        Assert.True(result == 4);
    }
}