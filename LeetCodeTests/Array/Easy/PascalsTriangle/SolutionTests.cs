using System.Collections.Generic;
using System.Linq;
using LeetCode.Array.Easy.PascalsTriangle;
using Xunit;

namespace LeetCodeTests.Array.Easy.PascalsTriangle
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var exResult = new List<List<int>>()
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1},
                new List<int> {1, 3, 3, 1},
                new List<int> {1, 4, 6, 4, 1},
            };
            var result = Solution.Generate(5);

            foreach (var (ex, res) in exResult.Zip(result))
            {
                Assert.Equal(ex, res);
            }

            exResult = new List<List<int>>()
            {
                new List<int> {1},
            };
            result = Solution.Generate(1);

            foreach (var (ex, res) in exResult.Zip(result))
            {
                Assert.Equal(ex, res);
            }
        }
    }
}