using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Design.Medium.DesignALeaderboard;

//https://leetcode.com/problems/design-a-leaderboard/description/
public class Leaderboard
{
    private readonly Dictionary<int, int> dict = new();

    public void AddScore(int playerId, int score)
    {
        if (!dict.ContainsKey(playerId)) dict.Add(playerId, score);
        else dict[playerId] += score;
    }

    public int Top(int K)
    {
        return dict.Values.OrderByDescending(x => x).Take(K).Sum();
    }

    public void Reset(int playerId)
    {
        dict[playerId] = 0;
    }
}