using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.KHighestRankedItemsWithinAPriceRange;

//https://leetcode.com/problems/k-highest-ranked-items-within-a-price-range/description/ 

public class ItemRank
{
    public int Row { get; set; }
    public int Col { get; set; }
    public int Distance { get; set; }
    public int Price { get; set; }
}

public class Solution
{
    private int[][] directions = new int[][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 } 
    };

    public IList<IList<int>> HighestRankedKItems(int[][] grid, int[] pricing, int[] start, int k)
    {
        var queue = Bfs(grid, pricing, start);

        List<IList<int>> result = new(k);
        while (k-- > 0 && queue.Count > 0)
            result.Add(queue.Dequeue());

        return result;
    }

    private PriorityQueue<List<int>, ItemRank> Bfs(int[][] grid, int[] pricing, int[] start)
    {
        PriorityQueue<List<int>, ItemRank> result = new(CreateComparer());

        Dictionary<int, HashSet<int>> visited = new();
        Queue<(int, int)> queue = new();
        queue.Enqueue((start[0], start[1]));

        var distance = 0;

        while(queue.Count > 0)
        {
            var size = queue.Count;
            distance++;

            for (int i = 0; i < size; i++)
            {
                var (row, col) = queue.Dequeue();

                if (row < 0 || col < 0) continue;
                if (row >= grid.Length || col >= grid[0].Length) continue;

                MarkAsVisited(visited, row, col);

                int price = grid[row][col];

                if (price == 0) continue;

                if (price > 1 && price <= pricing[1] && price >= pricing[0])
                    result.Enqueue(new List<int> { row, col }, 
                        new ItemRank { Row = row, Col = col, Distance = distance, Price = price });

                for (int y = 0; y < directions.Length; y++)
                {
                    var newRow = row + directions[y][0];
                    var newCol = col + directions[y][1];

                    if (IsVisited(visited, newRow, newCol)) continue;

                    queue.Enqueue((newRow, newCol));
                }
            }
        }

        return result;
    }

    private IComparer<ItemRank> CreateComparer()
    {
        return Comparer<ItemRank>.Create((x, y) =>
        {
            if (x.Distance != y.Distance)
                return x.Distance - y.Distance;
            if (x.Price != y.Price)
                return x.Price - y.Price;
            if (x.Row != y.Row)
                return x.Row - y.Row;

            return x.Col - y.Col;
        });
    }

    private void MarkAsVisited(Dictionary<int, HashSet<int>> visited, int row, int col)
    {
        if(!visited.ContainsKey(row)) visited.Add(row, new HashSet<int> { col });
        else visited[row].Add(col);
    }

    private bool IsVisited(Dictionary<int, HashSet<int>> visited, int row, int col)
    {
        return visited.ContainsKey(row) && visited[row].Contains(col);
    }
}