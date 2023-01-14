using LeetCode.PriorityQueue.Easy.LastStoneWeight;
using Xunit;

namespace LeetCodeTests.PriorityQueue.Easy.LastStoneWeight;
public class SolutionTests
{
    [Fact]
    public void LastStoneWeight_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        int[] stones = new int[] { 7, 6, 7, 6, 9 };

        // Act
        var result = solution.LastStoneWeight(stones);

        // Assert
        Assert.Equal(3, result);
    }
}
