using LeetCode.Array.Medium.RotateArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.RotateArray
{
    public class SolutionTests
    {
        [Fact]
        public void Rotate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {-1, -100, 3, 99};
            int k = 2;

            // Act
            solution.Rotate(nums, k);

            // Assert
            Assert.Equal(new int[] { 3, 99, -1, -100 }, nums);
        }
    }
}
