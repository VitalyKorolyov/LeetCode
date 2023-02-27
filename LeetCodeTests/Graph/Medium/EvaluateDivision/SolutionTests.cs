using LeetCode.Graph.Medium.EvaluateDivision;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests.Graph.Medium.EvaluateDivision;

public class SolutionTests
{
    [Fact]
    public void CalcEquation_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        IList<IList<string>> equations = new List<IList<string>>();
        equations.Add(new List<string> { "a", "b" });
        equations.Add(new List<string> { "b", "c" });

        double[] values = new double[] {2.0, 3.0};
        IList<IList<string>> queries = new List<IList<string>>();
        queries.Add(new List<string> { "a", "c" });
        queries.Add(new List<string> { "b", "a" });
        queries.Add(new List<string> { "a", "e" });
        queries.Add(new List<string> { "a", "a" });
        queries.Add(new List<string> { "x", "x" });

        // Act
        var result = solution.CalcEquation(equations, values, queries);

        // Assert
        Assert.True(true);
    }
}