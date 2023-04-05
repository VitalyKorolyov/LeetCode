using LeetCode.DynamicProgramming.Medium.UniqueBinarySearchTrees;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.UniqueBinarySearchTrees;

public class SolutionTests
{
    [Fact]
    public void NumTrees_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int n = 3;

        // Act
        var result = solution.NumTrees(n);

        // Assert
        Assert.True(result == 5);
    }
}