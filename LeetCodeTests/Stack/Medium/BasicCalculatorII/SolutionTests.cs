using LeetCode.Stack.Medium.BasicCalculatorII;
using Xunit;

namespace LeetCodeTests.Stack.Medium.BasicCalculatorII
{
    public class SolutionTests
    {
        [Fact]
        public void Calculate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = " 3+5 / 2 ";

            // Act
            var result = solution.Calculate(
                s);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
