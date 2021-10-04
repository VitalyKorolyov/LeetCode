namespace LeetCode.Array.Easy.RelativeRanks
{
    //https://leetcode.com/problems/relative-ranks/
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var index = new int[score.Length][];

            for (int i = 0; i < score.Length; i++)
            {
                index[i] = new int[2];
                index[i][0] = score[i];
                index[i][1] = i;
            }

            System.Array.Sort(index, (i1, i2) => i2[0].CompareTo(i1[0]));

            var res = new string[score.Length];

            for (int i = 0; i < index.Length; i++)
            {
                if (i == 0)
                {
                    res[index[i][1]] = "Gold Medal";
                    continue;
                }

                if (i == 1)
                {
                    res[index[i][1]] = "Silver Medal";
                    continue;
                }

                if (i == 2)
                {
                    res[index[i][1]] = "Bronze Medal";
                    continue;
                }

                res[index[i][1]] = (i+1).ToString();
            }

            return res;
        }
    }
}