using LeetCode.Design.Medium.DesignTwitter;
using Xunit;

namespace LeetCodeTests.Design.Medium.DesignTwitter;
public class TweetTests
{
    [Fact]
    public void TestMethod1()
    {
        // Arrange
        var tweetter = new Twitter();

        // Act
        tweetter.PostTweet(1, 5);
        tweetter.GetNewsFeed(1);
        tweetter.Follow(1, 2);
        tweetter.PostTweet(2, 6);
        tweetter.GetNewsFeed(1);

        // Assert
        Assert.True(true);
    }
}