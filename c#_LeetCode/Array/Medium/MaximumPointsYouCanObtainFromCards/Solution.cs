namespace LeetCode.Array.Medium.MaximumPointsYouCanObtainFromCards;

//https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/description/
public class Solution
{
    public int MaxScore(int[] cardPoints, int k)
    {
        int currentScore = 0;
        for (int i = cardPoints.Length - k; i < cardPoints.Length; i++)
            currentScore += cardPoints[i];

        int maxScore = currentScore;

        int left = 0;
        while(left < k)
        {
            currentScore -= cardPoints[cardPoints.Length - k + left];
            currentScore += cardPoints[left];
            left++;

            maxScore = System.Math.Max(maxScore, currentScore);
        }

        return maxScore;
    }
}