using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Medium.RewardTopKStudents;

//https://leetcode.com/problems/reward-top-k-students/description/
public class StudentScore
{
    public int Id { get; set; }
    public int Score { get; set; }
}

public class Solution
{
    public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, 
        string[] report, int[] student_id, int k)
    {
        HashSet<string> positiveWords = positive_feedback.ToHashSet();
        HashSet<string> negativeWords = negative_feedback.ToHashSet();

        Dictionary<int, HashSet<string>> studentToWords = student_id.Zip(report)
            .ToDictionary(x => x.First, x => new HashSet<string>(x.Second.Split()));

        Dictionary<int, int> studentToScore = new();
        for (int i = 0; i < student_id.Length; i++)
        {
            int studentId = student_id[i];
            studentToScore.Add(studentId, GetScore(studentToWords[studentId], positiveWords, negativeWords));
        }

        var comparer = Comparer<StudentScore>.Create(
            (x, y) => x.Score == y.Score ? x.Id.CompareTo(y.Id) : y.Score.CompareTo(x.Score));

        PriorityQueue<int, StudentScore> topKStudent = new(comparer);
        foreach (var studentId in studentToScore.Keys)
            topKStudent.Enqueue(studentId, new StudentScore {Id = studentId, Score = studentToScore[studentId] });

        List<int> result = new();
        for (int i = 0; i < k; i++)
            result.Add(topKStudent.Dequeue());

        return result;
    }

    private int GetScore(HashSet<string> report,
        HashSet<string> positive, HashSet<string> negative)
    {
        int score = 0;

        foreach (var p in report.Where(r => positive.Contains(r)))
            score += 3;
        foreach (var n in report.Where(r => negative.Contains(r)))
            score -= 1;
        
        return score;
    }
}
