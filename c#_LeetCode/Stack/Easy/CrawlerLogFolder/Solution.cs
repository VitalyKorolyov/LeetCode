using System.Collections.Generic;

namespace LeetCode.Stack.Easy.CrawlerLogFolder
{
    //https://leetcode.com/problems/crawler-log-folder/
    public class Solution
    {
        public int MinOperations(string[] logs)
        {
            var slack = new Stack<string>();

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] == "../")
                {
                    if (slack.Count > 0)
                    {
                        slack.Pop();
                    }
                    continue;
                }

                if (logs[i] == "./") continue;

                slack.Push(logs[i]);
            }

            return slack.Count;
        }
    }
}