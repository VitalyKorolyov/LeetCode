namespace LeetCode.String.Medium.PermutationInString
{
    //https://leetcode.com/problems/permutation-in-string/
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var freqS1 = new int[26];
            var freqS2 = new int[26];

            for (int i = 0; i < s1.Length; i++)
                freqS1[s1[i] - 'a']++;

            for (int start = 0, end = 0; end < s2.Length; end++)
            {
                if (end >= s1.Length)
                {
                    if (ContainsPermutation(freqS1, freqS2)) return true;

                    freqS2[s2[start] - 'a']--;
                    start++;
                }

                freqS2[s2[end] - 'a']++;
            }

            return ContainsPermutation(freqS1, freqS2);
        }

        private bool ContainsPermutation(int[] freqS1, int[] freqS2)
        {
            for (int i = 0; i < freqS2.Length; i++)
                if (freqS1[i] != freqS2[i]) return false;

            return true;
        }
    }
}
