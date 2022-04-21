using System.Collections.Generic;

namespace LeetCode.String.Easy.ReorderDataInLogFiles
{
    //https://leetcode.com/problems/reorder-data-in-log-files/
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var digitLog = new List<string>();
            var aplhabetLog = new List<string>();

            foreach (var log in logs)
            {
                if (char.IsDigit(log.Split(' ')[1][0]))
                {
                    digitLog.Add(log);
                }
                else
                {
                    aplhabetLog.Add(log);
                }
            }

            aplhabetLog.Sort(new LogComparetorWord());
            aplhabetLog.AddRange(digitLog);

            return aplhabetLog.ToArray();
        }

        public class LogComparetorWord : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                string[] log1 = x.Split(new char[] { ' ' }, 2);
                string[] log2 = y.Split(new char[] { ' ' }, 2);

                var cmp = log1[1].CompareTo(log2[1]);
                if (cmp != 0) return cmp;
                else return log1[0].CompareTo(log2[0]);
            }
        }
    }
}
