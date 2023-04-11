using LeetCode.Stack.Hard.BasicCalculatorIII;
using Xunit;

namespace LeetCodeTests.Stack.Hard.BasicCalculatorIII;

public class SolutionTests
{
    [Fact]
    public void Calculate_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string s = "1*2-3/4+5*6-7*8+9/10";

        // Act
        var result = solution.Calculate(s);

        // Assert
        Assert.True(result == -24);
    }
}