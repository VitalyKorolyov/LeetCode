using System.Collections.Generic;
using System.Text;

namespace LeetCode.Graph.Hard.AlienDictionary;

//https://leetcode.com/problems/alien-dictionary/description/
public class Solution
{
    public string AlienOrder(string[] words)
    {
        if (words == null || words.Length == 0) return "";

        Dictionary<char, List<char>> graph = new();
        Dictionary<char, int> parentCount = new();

        foreach (string word in words)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (graph.ContainsKey(word[i])) continue;

                graph.Add(word[i], new List<char>());
                parentCount.Add(word[i], 0);
            }
        }

        for (int i = 0; i + 1 < words.Length; i++) 
        {
            var firstWord = words[i];
            var secondWord = words[i + 1];

            var length = System.Math.Min(firstWord.Length, secondWord.Length);

            for(int j = 0; j < length; j++)
            {
                if (firstWord[j] != secondWord[j])
                {
                    graph[firstWord[j]].Add(secondWord[j]);
                    parentCount[secondWord[j]]++;
                    break;
                }
                if (j == length - 1 && firstWord.Length > secondWord.Length) return "";
            }
        }

        StringBuilder result = new();
        Queue<char> queue = new();

        foreach (var count in parentCount)
            if (count.Value == 0)
                queue.Enqueue(count.Key);

        while (queue.Count > 0)
        {
            char current = queue.Dequeue();
            result.Append(current);

            foreach(var childLetter in graph[current])
            {
                parentCount[childLetter]--;

                if (parentCount[childLetter] == 0)
                    queue.Enqueue(childLetter);
            }
        }

        if(result.Length != parentCount.Count) 
            return "";

        return result.ToString();
    }
}