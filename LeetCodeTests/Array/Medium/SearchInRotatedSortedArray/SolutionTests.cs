using LeetCode.Array.Medium.SearchInRotatedSortedArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.SearchInRotatedSortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void Search_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int target = 5;

            // Act
            var result = solution.Search(
                nums,
                target);

            // Assert
            Assert.True(result == 1);
        }
    }
}
