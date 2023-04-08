using System.Collections.Generic;

namespace LeetCode.Graph.Hard.WordLadder;

//https://leetcode.com/problems/word-ladder/description/
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> allWorlds = new(wordList);
        if (!allWorlds.Contains(endWord)) return 0;

        Queue<string> queue = new();
        HashSet<string> visited = new();
        queue.Enqueue(beginWord);
        visited.Add(beginWord);

        int changes = 1;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                string word = queue.Dequeue();
                if (word == endWord) return changes;

                for (int j = 0; j < word.Length; j++)
                {
                    for (int k = 'a'; k <= 'z'; k++)
                    {
                        var arr = word.ToCharArray();
                        arr[j] = (char)k;

                        string str = new(arr);
                        if (allWorlds.Contains(str) && !visited.Contains(str))
                        {
                            queue.Enqueue(str);
                            visited.Add(str);
                        }
                    }
                }
            }

            ++changes;
        }

        return 0;
    }
}
