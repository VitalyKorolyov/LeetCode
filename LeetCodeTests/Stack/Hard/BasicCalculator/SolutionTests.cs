using LeetCode.Stack.Hard.BasicCalculator;
using Xunit;

namespace LeetCodeTests.Stack.Hard.BasicCalculator;

public class SolutionTests
{
    [Fact]
    public void Calculate_StateUnderTest_ExpectedBehavior()
    {
        var solution = new Solution();

        var result = solution.Calculate(" (1+(4+5+2)-3)+(6+8)");

        Assert.True(23 == result);
    }
}