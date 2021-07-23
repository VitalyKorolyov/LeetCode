using Xunit;
using LeetCode.Array.Easy.CreateTargetArrayInTheGivenOrder;

namespace LeetCodeTests.Array.Easy.CreateTargetArrayInTheGivenOrder
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var nums1 = new[] { 0, 1, 2, 3, 4 };
            var indexes = new[] { 0, 1, 2, 2, 1 };

            Solution.CreateTargetArray(nums1, indexes);
        }
    }
}