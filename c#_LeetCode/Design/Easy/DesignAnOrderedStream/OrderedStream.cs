using System.Collections.Generic;

namespace LeetCode.Design.Easy.DesignAnOrderedStream;

//https://leetcode.com/problems/design-an-ordered-stream/description/
public class OrderedStream
{
    private readonly string[] stream;
    private int pointer = 0;

    public OrderedStream(int n)
    {
        stream = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        List<string> res = new();

        stream[idKey - 1] = value;

        while (pointer < stream.Length && stream[pointer] != null)
        {
            res.Add(stream[pointer]);
            pointer++;
        }

        return res;
    }
}