using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array.Medium.DotProductOfTwoSparseVectors
{
    //https://leetcode.com/problems/dot-product-of-two-sparse-vectors/
    public class SparseVector
    {
        public Dictionary<int, int> Vector { get; }

        public SparseVector(int[] nums)
        {
            Vector = new Dictionary<int, int>(nums.Count(x => x != 0));

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                    Vector.Add(i, nums[i]);
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            var res = 0;

            foreach (var v in vec.Vector)
            {
                if (Vector.ContainsKey(v.Key))
                    res += v.Value * Vector[v.Key];
            }

            return res;
        }
    }
}