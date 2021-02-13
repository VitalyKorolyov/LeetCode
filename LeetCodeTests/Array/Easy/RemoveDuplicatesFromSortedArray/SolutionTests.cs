using LeetCode.Array.Easy.RemoveDuplicatesFromSortedArray;
using Xunit;

namespace LeetCodeTests.Array.Easy.RemoveDuplicatesFromSortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var result = Solution.RemoveDuplicates(new[] {1, 1, 2});
        }
    }
}