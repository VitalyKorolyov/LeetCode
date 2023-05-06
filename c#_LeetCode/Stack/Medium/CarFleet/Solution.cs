using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Stack.Medium.CarFleet;

//https://leetcode.com/problems/car-fleet/
public class Solution
{
    private static readonly IComparer<(int, int)> comparer = 
        Comparer<(int, int)>.Create((x, y) => y.Item1.CompareTo(x.Item1));

    public int CarFleet(int target, int[] position, int[] speed)
    {
        List<(int, int)> list = new(position.Length);

        foreach ((int p, int s) in position.Zip(speed))
            list.Add((p, s));

        list.Sort(comparer);

        Stack<double> stack = new();
        for (int i = 0; i < list.Count; i++)
        {
            double time = ((double)target - list[i].Item1) / (double)list[i].Item2;

            if (stack.Count == 0)
                stack.Push(time);
            else if (stack.Peek() < time)
                stack.Push(time);
        }

        return stack.Count;
    }
}