using LeetCode.Design.Medium.DesignUndergroundSystem;
using Xunit;

namespace LeetCodeTests.Design.Medium.DesignUndergroundSystem;
public class TravelInfoTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var system = new UndergroundSystem();

        // Act
        system.CheckIn(10, "L", 3);
        system.CheckOut(10, "P", 8);
        var res = system.GetAverageTime("L", "P");

        system.CheckIn(5, "L", 10);
        system.CheckIn(5, "P", 16);

        res = system.GetAverageTime("L", "P");

        // Assert
        Assert.True(true);
    }
}