using LeetCode.Array.Medium.PeakIndexInAMountainArray;
using Xunit;

namespace LeetCodeTests.Array.Medium.PeakIndexInAMountainArray;

public class SolutionTests
{
    [Fact]
    public void PeakIndexInMountainArray_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] arr = new int[] { 1, 3, 5, 7, 3, 2 };

        // Act
        var result = solution.PeakIndexInMountainArray(arr);

        // Assert
        Assert.True(result == 3);
    }
}