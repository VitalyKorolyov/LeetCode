namespace LeetCode.Math.Easy.NumberOfStepsToReduceANumberToZero
{
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    public class Solution
    {
        public static int NumberOfSteps(int num)
        {
            var counter = 0;

            while (num != 0)
            {
                num = num % 2 == 0 ? num / 2 : num - 1;

                counter++;
            }


            return counter;
        }
    }
}