namespace LeetCode.String.Easy.FindWordsThatCanBeFormedByCharacters
{
    //https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/description/
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            int[] charCounter = new int[26];
            int[] temp = new int[26];
            int length = 0;

            for (int i = 0; i < chars.Length; i++)
                charCounter[chars[i] - 'a']++;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                    temp[j] = charCounter[j];

                bool canBeFormed = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    int index = words[i][j] - 'a';
                    if (temp[index] == 0)
                    {
                        canBeFormed = false;
                        break;
                    }

                    temp[index]--;
                }

                if (canBeFormed)
                    length += words[i].Length;
            }

            return length;
        }
    }
}
