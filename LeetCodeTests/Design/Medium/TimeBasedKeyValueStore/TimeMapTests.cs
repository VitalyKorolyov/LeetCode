using LeetCode.Design.Medium.TimeBasedKeyValueStore;
using Xunit;

namespace LeetCodeTests.Design.Medium.TimeBasedKeyValueStore;

public class TimeMapTests
{
    [Fact]
    public void Set_StateUnderTest_ExpectedBehavior()
    {
        var timeMap = new TimeMap();

        timeMap.Set("love", "high", 10);
        timeMap.Set("love", "low", 20);

        var res = timeMap.Get("love", 5);
        Assert.True(res == "");

        res = timeMap.Get("love", 10);
        Assert.True(res == "high");

        res = timeMap.Get("love", 15);
        Assert.True(res == "high");

        res = timeMap.Get("love", 20);
        Assert.True(res == "low");

        res = timeMap.Get("love", 25);
        Assert.True(res == "low");
    }
}