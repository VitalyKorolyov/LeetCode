using LeetCode.Array.Medium.FrequencyOfTheMostFrequentElement;
using Xunit;

namespace LeetCodeTests.Array.Medium.FrequencyOfTheMostFrequentElement;

public class SolutionTests
{
    [Fact]
    public void MaxFrequency_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = { 1, 2, 4 };
        int k = 5;

        // Act
        var result = solution.MaxFrequency(nums, k);

        // Assert
        Assert.Equal(3, result);

        nums = new int[] { 1, 4, 8, 13 };

        result = solution.MaxFrequency(nums, k);

        // Assert
        Assert.Equal(2, result);
    }
}