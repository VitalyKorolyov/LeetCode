namespace LeetCode.String.Easy.CountBinarySubstrings;

//https://leetcode.com/problems/count-binary-substrings/description/
public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        if(string.IsNullOrWhiteSpace(s)) return 0;

        int count = 0;
        char current = s[0];
        int countCurrent = 0;
        int countPrev = 0;

        foreach(char c in s)
        {
            if (c == current) countCurrent++;
            else
            {
                count += System.Math.Min(countCurrent, countPrev);
                countPrev = countCurrent;
                countCurrent = 1;
                current = c;
            }
        }

        return count + System.Math.Min(countCurrent, countPrev);
    }
}