namespace LeetCode.Array.Easy.FindSmallestLetterGreaterThanTarget
{
    //https://leetcode.com/problems/find-smallest-letter-greater-than-target/
    public class Solution
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            var l = 0;
            var r = letters.Length - 1;

            if (letters[l] > target) return letters[l];

            while (r >= l)
            {
                var pivot = l + (r - l) / 2;

                if (letters[pivot] > target)
                    r = pivot - 1;
                else
                    l = pivot + 1;
            }

            return letters[l % letters.Length];
        }
    }
}