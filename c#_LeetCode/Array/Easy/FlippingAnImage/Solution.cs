namespace LeetCode.Array.Easy.FlippingAnImage
{
    //https://leetcode.com/problems/flipping-an-image/
    public class Solution
    {
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0, z = image[i].Length - 1; j <= z; j++, z--)
                {
                    var valuej = image[i][j] == 0 ? 1 : 0;
                    var valuez = image[i][z] == 0 ? 1 : 0;

                    image[i][j] = valuez;
                    image[i][z] = valuej;
                }
            }

            return image;
        }
    }
}