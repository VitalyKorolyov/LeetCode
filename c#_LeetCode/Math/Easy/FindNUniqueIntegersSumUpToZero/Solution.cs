namespace LeetCode.Math.Easy.FindNUniqueIntegersSumUpToZero
{
    //https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
    public class Solution
    {
        public int[] SumZero(int n)
        {
            var mid = n / 2;

            var res = new int[n];
            for (int i = 0; i < mid; i++)
                res[i] = i + 1;

            if (n % 2 != 0)
                res[mid] = 0;
            else
                res[mid] = -res[mid - 1];

            for (int i = mid + 1; i < n; i++)
                res[i] = -res[i - (mid + 1)];

            return res;
        }
    }
}