namespace LeetCode.Matrix.Easy.FlippingAnImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (int k = 0; k < image.Length; k++)
            {
                for (int i = 0, j = image[k].Length - 1; i <= j; i++, j--)
                {
                    if (image[k][i] == image[k][j])
                        Invert(image[k], i, j);
                    else 
                    {
                        Flip(image[k], i, j);
                        Invert(image[k], i, j);
                    }
                }
            }

            return image;
        }

        private void Invert(int[] image, int i, int j)
        {
            if(i == j)
            {
                image[i] = image[i] == 1 ? 0 : 1;
                return;
            }

            image[i] = image[i] == 1 ? 0 : 1;
            image[j] = image[j] == 1 ? 0 : 1;
        }

        private void Flip(int[] image, int i, int j)
        {
            if (i == j) return;

            var temp = image[i];
            image[i] = image[j];
            image[j] = temp;
        }
    }
}
