namespace LeetCode.String.Easy.RansomNote
{
    //https://leetcode.com/problems/ransom-note/description/
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] counter = new int[26];

            for (int i = 0; i < magazine.Length; i++)
                counter[magazine[i] - 'a']++;

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (counter[ransomNote[i] - 'a'] == 0) return false;
                counter[ransomNote[i] - 'a']--;
            }

            return true;
        }
    }
}
