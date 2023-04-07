using LeetCode.Design.Medium.FirstUniqueNumber;
using Xunit;

namespace LeetCodeTests.Design.Medium.FirstUniqueNumber;

public class UniqueNumberTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var firstUnique = new FirstUnique(new int[] { 2, 3, 5 });

        // Act
        firstUnique.ShowFirstUnique();
        firstUnique.Add(5);
        firstUnique.ShowFirstUnique();

        // Assert
        Assert.True(false);
    }
}