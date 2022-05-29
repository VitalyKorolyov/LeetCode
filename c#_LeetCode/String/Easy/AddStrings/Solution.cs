using System.Collections.Generic;
using System.Linq;

namespace LeetCode.String.Easy.AddStrings
{
    //https://leetcode.com/problems/add-strings/
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            var biggest = num1.Length > num2.Length ? num1 : num2;
            var lowest = num1.Length > num2.Length ? num2 : num1;

            var additional = 0;
            var res = new LinkedList<int>();
            var lowestIndex = lowest.Length - 1;

            for (int i = biggest.Length - 1; i >= 0; i--)
            {
                if(lowestIndex >= 0)
                {
                    int current = int.Parse(biggest[i].ToString()) 
                        + int.Parse(lowest[lowestIndex--].ToString()) + additional;
                    additional = 0;

                    if(current > 9)
                    {
                        additional = 1;
                        current -= 10;
                    }

                    res.AddFirst(current);
                }
                else
                {
                    var current = int.Parse(biggest[i].ToString()) + additional;
                    additional = 0;

                    if (current > 9)
                    {
                        additional = 1;
                        current -= 10;
                    }

                    res.AddFirst(current);
                }
            }

            if(additional > 0)
                res.AddFirst(additional);

            return string.Join("", res.Select(x => x.ToString()));
        }
    }
}
