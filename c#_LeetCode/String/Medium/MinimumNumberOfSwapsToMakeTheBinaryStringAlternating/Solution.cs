namespace LeetCode.String.Medium.MinimumNumberOfSwapsToMakeTheBinaryStringAlternating;

//https://leetcode.com/problems/minimum-number-of-swaps-to-make-the-binary-string-alternating/description/
public class Solution
{
    public int MinSwaps(string s)
    {
        int countOne = 0, countZero = 0;
        foreach (char c in s)
        {
            if (c == '0') countZero++;
            else countOne++;
        }

        if (System.Math.Abs(countOne - countZero) > 1) return -1;

        if (countZero > countOne) return CountSwaps(s, '0');
        if (countZero < countOne) return CountSwaps(s, '1');

        return System.Math.Min(CountSwaps(s, '0'), CountSwaps(s, '1'));
    }

    private int CountSwaps(string s, char start)
    {
        int wrongPositions = 0;

        foreach (char current in s)
        {
            if (current != start) wrongPositions++;
            start = start == '1' ? '0' : '1';
        }

        return wrongPositions / 2;
    }
}