using LeetCode.Math.Medium.ReverseInteger;
using Xunit;

namespace LeetCodeTests.Math.Medium.ReverseInteger;

public class SolutionTests
{
    [Fact]
    public void Reverse_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int x = 0;

        // Act
        var result = solution.Reverse(123);

        // Assert
        Assert.True(result == 321);
    }
}