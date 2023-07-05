using LeetCode.Stack.Medium.RemoveAllAdjacentDuplicatesInStringII;
using Xunit;

namespace LeetCodeTests.Stack.Medium.RemoveAllAdjacentDuplicatesInStringII;

public class SolutionTests
{
    [Fact]
    public void RemoveDuplicates_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "deeedbbcccbdaa";
        int k = 3;

        // Act
        var result = solution.RemoveDuplicates(s, k);

        // Assert
        Assert.Equal("aa", result);
    }
}