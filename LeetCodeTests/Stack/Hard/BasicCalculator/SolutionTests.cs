using LeetCode.Stack.Hard.BasicCalculator;
using Xunit;

namespace LeetCodeTests.Stack.Hard.BasicCalculator
{
    public class SolutionTests
    {
        [Fact]
        public void Calculate_StateUnderTest_ExpectedBehavior()
        {
            //Arrange
            var solution = new Solution();
            string s = "(1+(4+5+2)-3)+(6+8)";

            //Act
            var result = solution.Calculate(s);

            //Assert
            Assert.True(2 == result);

            s = " 2-1 + 2 ";

            //Act
            result = solution.Calculate(s);

            //Assert
            Assert.True(3 == result);
        }
    }
}
