namespace LeetCode.DynamicProgramming.Medium.NumberOfWaysToSelectBuildings;

//https://leetcode.com/problems/number-of-ways-to-select-buildings/description/
public class Solution
{
    public long NumberOfWays(string s)
    {
        long totalZeros = 0;
        for (int i = 0; i < s.Length; i++)
            if (s[i] == '0') totalZeros++;

        long totalOnes = s.Length - totalZeros;

        long leftOnes = s[0] == '1' ? 1 : 0;
        long leftZeros = s[0] == '0' ? 1 : 0;

        long result = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                result += (totalZeros - leftZeros) * leftZeros;
                leftOnes++;
            }
            else
            {
                result += (totalOnes - leftOnes) * leftOnes;
                leftZeros++;
            }
        }

        return result;
    }
}