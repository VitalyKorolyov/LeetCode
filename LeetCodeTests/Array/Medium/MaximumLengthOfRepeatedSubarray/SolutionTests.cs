using LeetCode.Array.Medium.MaximumLengthOfRepeatedSubarray;
using Xunit;

namespace LeetCodeTests.Array.Medium.MaximumLengthOfRepeatedSubarray
{
    public class SolutionTests
    {
        [Fact]
        public void FindLength_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            var nums1 = new[] { 1, 2, 3, 2, 1 };
            var nums2 = new[] { 3, 2, 1, 4, 7 };

            // Act
            var result = solution.FindLength(nums1, nums2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
