namespace LeetCode.Matrix.Easy.FloodFill
{
    //https://leetcode.com/problems/flood-fill/
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color) return image;

            PerformFloodFill(image, sr, sc, image[sr][sc], color);

            return image;
        }

        private void PerformFloodFill(int[][] image, int i, int j, int originalColor, int newColor)
        {
            if (i < 0 || i >= image.Length) return;
            if (j < 0 || j >= image[i].Length) return;
            if (image[i][j] != originalColor) return;

            image[i][j] = newColor;

            PerformFloodFill(image, i, j + 1, originalColor, newColor);
            PerformFloodFill(image, i, j - 1, originalColor, newColor);
            PerformFloodFill(image, i + 1, j, originalColor, newColor);
            PerformFloodFill(image, i - 1, j, originalColor, newColor);
        }
    }
}
