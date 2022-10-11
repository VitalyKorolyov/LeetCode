using LeetCode.Array.Medium.IncreasingTripletSubsequence;
using Xunit;

namespace LeetCodeTests.Array.Medium.IncreasingTripletSubsequence
{
    public class SolutionTests
    {
        [Fact]
        public void IncreasingTriplet_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {20, 100, 10, 12, 5, 13};

            // Act
            var result = solution.IncreasingTriplet(nums);

            // Assert
            Assert.True(result);
        }
    }
}
