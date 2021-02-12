using Xunit;
using LeetCode.Array.Easy.MergeSortedArray;

namespace LeetCodeTests.Array.Easy.MergeSortedArray
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            var nums1 = new[] {1, 2, 3, 0, 0, 0};
            var nums2 = new[] { 2, 5, 6 };
            var expectedResult = new[] { 1, 2, 2, 3, 5, 6 };

            Solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);

            nums1 = new[] { 0, 2, 3, 0, 0, 0 };
            nums2 = new[] { 2, 5, 6 };
            expectedResult = new[] { 0, 2, 2, 3, 5, 6 };

            Solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);

            nums1 = new[] { 0, 0, 3, 0, 0, 0 };
            nums2 = new[] { 2, 5, 6 };
            expectedResult = new[] { 0, 0, 2, 3, 5, 6 };

            Solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);

            nums1 = new[] { 1 };
            nums2 = new int[0];
            expectedResult = new[] { 1 };

            Solution.Merge(nums1, 1, nums2, 0);

            Assert.Equal(expectedResult, nums1);

            nums1 = new[] { -1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };
            nums2 = new[] { -1, -1, 0, 0, 1, 2 };
            expectedResult = new[] { -1, -1, -1, 0, 0, 0, 0, 0, 1, 2, 3 };

            Solution.Merge(nums1, 5, nums2, 6);

            Assert.Equal(expectedResult, nums1);
        }
    }
}