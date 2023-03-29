using LeetCode.Stack.Medium.EvaluateReversePolishNotation;
using Xunit;

namespace LeetCodeTests.Stack.Medium.EvaluateReversePolishNotation;

public class SolutionTests
{
    [Fact]
    public void EvalRPN_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] tokens = new string[] { "4", "3", "-" };

        // Act
        var result = solution.EvalRPN(tokens);

        // Assert
        Assert.True(result == 1);
    }
}