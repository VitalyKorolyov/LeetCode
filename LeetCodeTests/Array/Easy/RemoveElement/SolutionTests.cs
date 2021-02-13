using LeetCode.Array.Easy.RemoveElement;
using Xunit;

namespace LeetCodeTests.Array.Easy.RemoveElement
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var result = Solution.RemoveElement(new[] { 3, 2, 2, 3 }, 3);
        }
    }
}