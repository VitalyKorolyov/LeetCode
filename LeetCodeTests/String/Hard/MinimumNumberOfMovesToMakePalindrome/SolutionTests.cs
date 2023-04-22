using LeetCode.String.Hard.MinimumNumberOfMovesToMakePalindrome;
using Xunit;

namespace LeetCodeTests.String.Hard.MinimumNumberOfMovesToMakePalindrome;

public class SolutionTests
{
    [Fact]
    public void MinMovesToMakePalindrome_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "letelt";

        // Act
        var result = solution.MinMovesToMakePalindrome(s);

        // Assert
        Assert.True(result == 2);
    }
}