using LeetCode.HashTable.Easy.VerifyingAnAlienDictionary;
using Xunit;

namespace LeetCodeTests.HashTable.Easy.VerifyingAnAlienDictionary;

public class SolutionTests
{
    [Fact]
    public void IsAlienSorted_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var solution = new Solution();
        string[] words = { "my", "f" };
        string order = "gelyriwxzdupkjctbfnqmsavho";

        // Act
        var result = solution.IsAlienSorted(
            words,
            order);

        // Assert
        Assert.True(result);
    }
}