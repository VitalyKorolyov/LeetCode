namespace LeetCode.Array.Easy.XOROperationInAnArray
{
    //https://leetcode.com/problems/xor-operation-in-an-array/
    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                result ^= start + 2 * i;
            }

            return result;
        }
    }
}