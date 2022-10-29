namespace LeetCode.Array.Easy.PlusOne
{
    //https://leetcode.com/problems/plus-one/
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            bool isOne = true;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (isOne)
                {
                    digits[i] += 1;
                    if (digits[i] > 9)
                    {
                        digits[i] = 0;
                        continue;
                    }
                    else isOne = false;
                }
                else break;
            }

            digits = isOne ? new int[digits.Length + 1] : digits;
            digits[0] = isOne ? 1 : digits[0];

            return digits;
        }
    }
}
