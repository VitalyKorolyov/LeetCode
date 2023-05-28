namespace LeetCode.String.Easy.ValidAnagram;

//https://leetcode.com/problems/valid-anagram/
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        int[] letterCount = new int[26];

        for (int i = 0; i < t.Length; i++)
            letterCount[t[i] - 'a']++;

        for (int i = 0;i < s.Length; i++)
            letterCount[s[i] - 'a']--;

        for (int i = 0; i < letterCount.Length; i++)
            if (letterCount[i] != 0) return false;

        return true;
    }
}