namespace LeetCode.String.Medium.AdditiveNumber;

//https://leetcode.com/problems/additive-number/
public class Solution
{
    public bool IsAdditiveNumber(string s)
    {
        for (int i = 1; i < s.Length; i++)
        {
            long a = Parse(s.Substring(0, i));
            if (a == -1) continue;

            for (int j = i + 1; j < s.Length; j++)
            {
                long b = Parse(s.Substring(i, j - i));
                if (b == -1) continue;
                if (Dfs(s.Substring(j), a, b)) return true;
            }
        }

        return false;
    }

    private bool Dfs(string s, long a, long b)
    {
        if (s.Length == 0) return true;

        for (int i = 1; i <= s.Length; i++)
        {
            long c = Parse(s.Substring(0, i));
            if (c == -1) continue;

            if (c - a == b && Dfs(s.Substring(i), b, c))
                return true;
        }

        return false;
    }

    private long Parse(string s)
    {
        if (!s.Equals("0") && s.StartsWith("0")) return -1;

        long result = 0;
        if (!long.TryParse(s, out result))
            return -1;
        
        return result;
    }
}
