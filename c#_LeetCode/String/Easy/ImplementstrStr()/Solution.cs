namespace LeetCode.String.Easy
{
    //https://leetcode.com/problems/implement-strstr/
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if(haystack.Length < needle.Length) return -1;

            for (var i = 0; i < haystack.Length; i++)
            {
                var k = i; 
                var j = 0;
                var found = true;

                while (j < needle.Length && k < haystack.Length)
                {
                    if (haystack[k++] == needle[j++]) continue;

                    found = false;
                    break;
                }

                if (found) return i;
            }

            return -1;
        }
    }
}