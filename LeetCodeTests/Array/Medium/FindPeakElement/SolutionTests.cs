using Xunit;
using LeetCode.Array.Medium.FindPeakElement;

namespace LeetCodeTests.Array.Medium.FindPeakElement
{
    public class SolutionTests
    {
        [Fact]
        public void Tests()
        {
            var result = Solution.FindPeakElement(new[] {1, 2, 3, 1});
            Assert.Equal(2, result);

            result = Solution.FindPeakElement(new[] { 1, 2, 1, 3, 5, 6, 4 });
            Assert.Equal(5, result);

            result = Solution.FindPeakElement(new[] { 10 });
            Assert.Equal(0, result);
        }
    }
}