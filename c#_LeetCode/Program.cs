using System;
using LeetCode.Array.Easy.RunningSumOf1dArray;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = Solution.RunningSum(new []{ 1, 1, 1, 1, 1 });

            Console.WriteLine(a);
        }
    }
}