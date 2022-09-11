using LeetCode.DynamicProgramming.Hard.TotalAppealOfAString;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Hard.TotalAppealOfAString
{
    public class SolutionTests
    {
        [Fact]
        public void AppealSum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string s = "fxfz";

            // Act
            var result = solution.AppealSum(s);

            // Assert
            Assert.True(18 == result);
        }
    }
}
