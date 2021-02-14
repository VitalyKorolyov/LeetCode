using Xunit;
using LeetCode.Array.Medium.FindMinimumInRotatedSortedArray;

namespace LeetCodeTests.Array.Medium.FindMinimumInRotatedSortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void Tests()
        {
            var result = Solution.FindMin(new[] { 3, 4, 5, 1, 2 });
            Assert.Equal(1, result);

            result = Solution.FindMin(new[] { 4, 5, 6, 7, 0, 1, 2 });
            Assert.Equal(0, result);

            result = Solution.FindMin(new[] { 11, 13, 15, 17 });
            Assert.Equal(11, result);

            result = Solution.FindMin(new[] { 15 });
            Assert.Equal(15, result);

            result = Solution.FindMin(new[] { 2, 3, 1 });
            Assert.Equal(1, result);

            result = Solution.FindMin(new[] { 1, 2 });
            Assert.Equal(1, result);

            result = Solution.FindMin(new[] { 2, 1 });
            Assert.Equal(1, result);

            result = Solution.FindMin(new[] { 2, 3, 4, 5, 1 });
            Assert.Equal(1, result);

            result = Solution.FindMin(new[] { 5, 1, 2, 3, 4 });
            Assert.Equal(1, result);
        }
    }
}