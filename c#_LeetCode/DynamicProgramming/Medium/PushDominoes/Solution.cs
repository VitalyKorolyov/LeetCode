using System.Text;

namespace LeetCode.DynamicProgramming.Medium.PushDominoes
{
    //https://leetcode.com/problems/push-dominoes/description/
    public class Solution
    {
        public string PushDominoes(string dominoes)
        {
            var r = new int[dominoes.Length];
            var l = new int[dominoes.Length];

            var counter = 0;
            for (int i = 0; i < dominoes.Length; i++)
            {
                if (dominoes[i] == 'R')
                {
                    r[i] = 0;
                    counter = 1;
                }
                else 
                {
                    if (dominoes[i] == 'L') counter = 0;
                    else r[i] = counter > 0 ? counter++ : 0;
                }
            }

            counter = 0;
            for (int i = dominoes.Length - 1; i >= 0; i--)
            {
                if (dominoes[i] == 'L')
                {
                    l[i] = 0;
                    counter = 1;
                }
                else
                {
                    if (dominoes[i] == 'R') counter = 0;
                    else l[i] = counter > 0 ? counter++ : 0;
                }
            }

            StringBuilder result = new(dominoes.Length);
            for (int i = 0; i < dominoes.Length; i++)
            {
                if (r[i] == l[i]) result.Append(dominoes[i]);
                else
                {
                    if (r[i] != 0 && l[i] != 0) result.Append(r[i] > l[i] ? 'L' : 'R');
                    else result.Append(r[i] > l[i] ? 'R' : 'L');
                }
            }

            return result.ToString();
        }
    }
}
