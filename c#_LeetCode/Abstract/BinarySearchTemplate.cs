using System.Linq;

namespace LeetCode.Abstract;

public class BinarySearchTemplate
{
    public int BinarySearch(int[] array)
    {
        int left = array.Min();
        int right = array.Max(); // could be [0, n], [1, n] etc. Depends on problem

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (Condition(mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }

    private bool Condition(int value)
    {
        return true;
    }
}
