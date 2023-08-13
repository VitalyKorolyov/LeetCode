using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Hard.WordLadderII;

public class Solution
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> allWords = new(wordList);
        List<IList<string>> result = new();

        if (!allWords.Contains(endWord)) return result;

        HashSet<string> visited = new();
        Queue<List<string>> queue = new();

        queue.Enqueue(new List<string>() { beginWord });
        visited.Add(beginWord);

        while (queue.Count > 0)
        {
            var size = queue.Count;
            List<string> seen = new();

            for (int i = 0; i < size; i++)
            {
                var currentChain = queue.Dequeue();
                var lastWord = currentChain.Last();

                if (lastWord == endWord)
                {
                    result.Add(currentChain);
                    continue;
                }

                for (int j = 0; j < lastWord.Length; j++)
                {
                    var lastWordMod = lastWord.ToCharArray();

                    for (int k = 'a'; k <= 'z'; k++)
                    {
                        lastWordMod[j] = (char)k;

                        string currentWord = new(lastWordMod);

                        if (allWords.Contains(currentWord) && !visited.Contains(currentWord))
                        {
                            List<string> newChain = new(currentChain);
                            newChain.Add(currentWord);

                            queue.Enqueue(newChain);
                            seen.Add(currentWord);
                        }
                    }
                }
            }

            if (result.Any()) return result;

            foreach (var item in seen)
                visited.Add(item);
        }

        return result;
    }
}
