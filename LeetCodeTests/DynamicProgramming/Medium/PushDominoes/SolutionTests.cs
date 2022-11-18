using LeetCode.DynamicProgramming.Medium.PushDominoes;
using Xunit;

namespace LeetCodeTests.DynamicProgramming.Medium.PushDominoes
{
    public class SolutionTests
    {
        [Fact]
        public void PushDominoes_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            string dominoes = ".L.R...LR..L..";

            // Act
            var result = solution.PushDominoes(dominoes);

            // Assert
            Assert.True(result == "LL.RR.LLRRLL..");
        }
    }
}
