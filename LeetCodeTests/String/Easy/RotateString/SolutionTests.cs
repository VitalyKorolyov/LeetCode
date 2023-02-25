using LeetCode.String.Easy.RotateString;
using Xunit;

namespace LeetCodeTests.String.Easy.RotateString;

public class SolutionTests
{
    [Fact]
    public void Rotate_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string str = "GeeksforGeeks";
        int leftShift = 4;
        int rightShift = 3;

        // Act
        var result = solution.Rotate(str, leftShift, rightShift);

        // Assert
        Assert.True(result == "eeksforGeeksG");
    }
}