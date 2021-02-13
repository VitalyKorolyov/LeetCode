using LeetCode.Array.Medium._3Sum_Closest;
using Xunit;

namespace LeetCodeTests.Array.Easy._3Sum_Closest
{
    //https://leetcode.com/problems/3sum-closest/
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var result = Solution.ThreeSumClosest(new[] { -1, 2, 1, -4 }, 1);
            Assert.Equal(2, result);

            result = Solution.ThreeSumClosest(new[] { 3, 2, 1 }, 1);
            Assert.Equal(6, result);

            result = Solution.ThreeSumClosest(new[] { 1, 1, 1, -1, 0, 1 }, 1);
            Assert.Equal(1, result);

            result = Solution.ThreeSumClosest(new[] { 1, 1, -1, -1, 3 }, 3);
            Assert.Equal(3, result);
        }
    }
}