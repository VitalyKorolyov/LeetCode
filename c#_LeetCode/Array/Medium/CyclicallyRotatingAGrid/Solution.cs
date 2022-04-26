namespace LeetCode.Array.Medium.CyclicallyRotatingAGrid
{
    //https://leetcode.com/problems/cyclically-rotating-a-grid/
    public class Solution
    {
        public int[][] RotateGrid(int[][] grid, int k)
        {
            int bottom = grid.Length - 1;
            int right = grid[0].Length - 1;
            int left = 0;
            int top = 0;

            while(bottom > top && right > left)
            {
                var elementsInLayer = (bottom - top) * 2 + (right - left) * 2;
                var nRotation = k % elementsInLayer;

                while(nRotation > 0)
                {
                    var saved = grid[top][left];

                    for (int i = left; i < right; i++)
                        grid[top][i] = grid[top][i + 1];

                    for (int i = top; i < bottom; i++)
                        grid[i][right] = grid[i + 1][right];

                    for (int i = right; i > left; i--)
                        grid[bottom][i] = grid[bottom][i - 1];

                    for (int i = bottom; i > top; i--)
                        grid[i][left] = grid[i - 1][left];

                    grid[top + 1][left] = saved;

                    nRotation--;
                }

                top++; left++; right--; bottom--;
            }

            return grid;
        }
    }
}
