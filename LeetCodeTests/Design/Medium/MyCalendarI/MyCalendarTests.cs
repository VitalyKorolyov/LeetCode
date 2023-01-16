using LeetCode.Design.Medium.MyCalendarI;
using Xunit;

namespace LeetCodeTests.Design.Medium.MyCalendarI;

public class MyCalendarTests
{
    [Fact]
    public void Book_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var myCalendar = new MyCalendar();

        // Act
        var result = myCalendar.Book(47, 50);
        Assert.True(result);

        result = myCalendar.Book(33, 41);
        Assert.True(result);

        result = myCalendar.Book(39, 45);
        Assert.False(result);

        result = myCalendar.Book(33, 42);
        Assert.False(result);
    }
}
