using System.Collections.Generic;

namespace LeetCode.String.Hard.MinimumNumberOfMovesToMakePalindrome;

//https://leetcode.com/problems/minimum-number-of-moves-to-make-palindrome/description/
public class Solution
{
    public int MinMovesToMakePalindrome(string s)
    {
        int count = 0;
        List<char> list = new(s);

        while (list.Count > 2)
        {
            char ch1 = list[0];
            char ch2 = list[list.Count - 1];

            if(ch1 == ch2)
            {
                list.RemoveAt(list.Count - 1);
                list.RemoveAt(0);
            }
            else
            {
                int id1 = list.LastIndexOf(ch1);
                int id2 = list.IndexOf(ch2);

                int step1 = list.Count - id1 - 1;
                int step2 = id2;

                if(step1 > step2)
                {
                    list.RemoveAt(id2);
                    list.RemoveAt(list.Count - 1);
                    count += step2;
                }
                else
                {
                    list.RemoveAt(id1);
                    list.RemoveAt(0);
                    count += step1;
                }
            }
        }

        return count;
    }
}
