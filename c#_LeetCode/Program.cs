using System;
using LeetCode.Array.Easy.ShuffleTheArray;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = Solution.Shuffle(new []{ 1, 2, 3, 4, 11, 22, 33, 44 }, 4);

            Console.WriteLine(a);
        }
    }
}