using System.Collections.Generic;

namespace LeetCode.Stack.Hard
{
    //https://leetcode.com/problems/maximum-frequency-stack/
    public class FreqStack
    {
        Dictionary<int, Stack<int>> groups;
        Dictionary<int, int> freqs;
        int maxFreq;

        public FreqStack()
        {
            groups = new Dictionary<int, Stack<int>>();
            freqs = new Dictionary<int, int>();
            maxFreq = 0;
        }

        public void Push(int x)
        {
            if (!freqs.TryAdd(x, 1))
                freqs[x]++;

            if (freqs[x] > maxFreq)
                maxFreq = freqs[x];

            Stack<int> group = null;
            if (!groups.TryGetValue(freqs[x], out group))
            {
                group = new Stack<int>();
                groups.Add(freqs[x], group);
            }
            group.Push(x);
        }

        public int Pop()
        {
            int x = groups[maxFreq].Pop();
            freqs[x]--;

            if (groups[maxFreq].Count == 0)
            {
                maxFreq--;
                groups.Remove(maxFreq);
            }
            if(freqs[x] == 0)
            {
                freqs.Remove(x);
            }

            return x;
        }
    }
}
