namespace LeetCode.String.Easy.RotateString;

public class Solution
{
    public string Rotate(string str, int leftShift, int rightShift)
    {
        if (leftShift == rightShift) return str;

        leftShift = leftShift % str.Length;
        rightShift = rightShift % str.Length;

        if (rightShift > leftShift)
        {
            rightShift = rightShift - leftShift;
            return LeftRotate(str, str.Length - rightShift);
        }
        else
        {
            leftShift = leftShift - rightShift;
            return LeftRotate(str, leftShift);
        }
    }

    static string LeftRotate(string str, int leftShift)
    {
        return str.Substring(leftShift, str.Length - leftShift) + str.Substring(0, leftShift);
    }
}
