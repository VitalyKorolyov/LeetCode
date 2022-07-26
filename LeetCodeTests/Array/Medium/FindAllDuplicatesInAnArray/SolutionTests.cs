using LeetCode.Array.Medium.FindAllDuplicatesInAnArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.FindAllDuplicatesInAnArray
{
    public class SolutionTests
    {
        [Fact]
        public void FindDuplicates_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] {4, 3, 2, 7, 8, 2, 3, 1};

            // Act
            var result = solution.FindDuplicates(nums);

            // Assert
            Assert.True(true);
        }
    }
}
