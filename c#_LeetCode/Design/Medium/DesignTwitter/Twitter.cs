using System.Collections.Generic;

namespace LeetCode.Design.Medium.DesignTwitter;

//https://leetcode.com/problems/design-twitter/description/
class Tweet
{
    public int Time { get; init; }
    public int Id { get; init; }
}

public class Twitter
{
    private readonly Dictionary<int, HashSet<int>> followers = new();
    private readonly Dictionary<int, LinkedList<Tweet>> tweets = new();
    private readonly IComparer<int> comparer = Comparer<int>.Create((x, y) => x - y);
    private int currentTime = 0;

    public void PostTweet(int userId, int tweetId)
    {
        if (!followers.ContainsKey(userId)) followers.Add(userId, new HashSet<int>());
        followers[userId].Add(userId);

        if (!tweets.ContainsKey(userId)) tweets.Add(userId, new LinkedList<Tweet>());
        tweets[userId].AddFirst(new Tweet { Id = tweetId, Time = ++currentTime });

        if (tweets[userId].Count > 10)
            tweets[userId].RemoveLast();
    }

    public IList<int> GetNewsFeed(int userId)
    {
        PriorityQueue<int, int> priorityQueue = new(comparer);

        if (followers.ContainsKey(userId))
        {
            foreach (var followeeId in followers[userId])
                if (tweets.ContainsKey(followeeId))
                    foreach (var tweet in tweets[followeeId])
                        priorityQueue.Enqueue(tweet.Id, tweet.Time);
        }

        List<int> result = new(10);
        for (int i = 0; i < 10 && priorityQueue.Count > 0; i++)
            result.Add(priorityQueue.Dequeue());
        return result;
    }

    public void Follow(int followerId, int followeeId)
    {
        if(!followers.ContainsKey(followerId))
            followers.Add(followerId, new HashSet<int>());

        followers[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (!followers.ContainsKey(followerId)) return;
        followers[followerId].Remove(followeeId);
    }
}