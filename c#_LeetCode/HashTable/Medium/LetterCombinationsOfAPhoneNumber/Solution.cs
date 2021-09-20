using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashTable.Medium.LetterCombinationsOfAPhoneNumber
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public class Solution
    {
        private readonly Dictionary<char, List<char>> hashMap = new Dictionary<char, List<char>>()
        {
            {'2', new List<char>{'a', 'b', 'c'} },
            {'3', new List<char>{'d', 'e', 'f'} },
            {'4', new List<char>{'g', 'h', 'i'} },
            {'5', new List<char>{'j', 'k', 'l'} },
            {'6', new List<char>{'m', 'n', 'o'} },
            {'7', new List<char>{'p', 'q', 'r', 's'} },
            {'8', new List<char>{'t', 'u', 'v'} },
            {'9', new List<char>{'w', 'x', 'y', 'z'} }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var res = new List<string>();
            if (!digits.Any()) return res;

            var sizeMoreThan2 = digits.Length >= 2;
            var sizeMoreThan3 = digits.Length >= 3;
            var sizeIs4 = digits.Length == 4;

            for (int i = 0; i < hashMap[digits[0]].Count; i++)
            {
                var str = hashMap[digits[0]][i].ToString();
                if (sizeMoreThan2)
                {
                    for (int j = 0; j < hashMap[digits[1]].Count; j++)
                    {
                        var str1 = str + hashMap[digits[1]][j].ToString();

                        if (sizeMoreThan3)
                        {
                            for (int k = 0; k < hashMap[digits[2]].Count; k++)
                            {
                                var str3 = str1 + hashMap[digits[2]][k].ToString();

                                if (sizeIs4)
                                {
                                    for (int l = 0; l < hashMap[digits[3]].Count; l++)
                                        res.Add(str3 + hashMap[digits[3]][l].ToString());
                                }
                                else
                                {
                                    res.Add(str3);
                                }
                            }
                        }
                        else
                        {
                            res.Add(str1);
                        }
                    }
                }
                else
                {
                    res.Add(str);
                }
            }

            return res;
        }
    }
}