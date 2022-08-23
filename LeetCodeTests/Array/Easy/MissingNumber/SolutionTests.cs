using LeetCode.Array.Easy.MissingNumber;
using Xunit;

namespace LeetCodeTests.Array.Easy.MissingNumber
{
    public class SolutionTests
    {
        [Fact]
        public void MissingNumber_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int[] nums = new int[] { 1, 5, 2, 6, 4 };

            // Act
            var result = Solution.MissingNumber(nums);

            // Assert
            Assert.True(3 == result);
        }
    }
}
