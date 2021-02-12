using Xunit;
using LeetCode.BST.Easy.ConvertSortedArrayToBinarySearchTree;

namespace LeetCodeTests.BST.Easy.ConvertSortedArrayToBinarySearchTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var result = Solution.SortedArrayToBST(new[] {-10, -3, 0, 5, 9});
        }
    }
}