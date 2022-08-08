public class CountIslands
{
    public void Test()
    {
        char[][] grid = new char[4][];
        grid[0] = new char[5] { '1', '1', '1', '1', '0' };
        grid[1] = new char[5] { '1', '1', '0', '1', '0' };
        grid[2] = new char[5] { '1', '1', '0', '0', '0' };
        grid[3] = new char[5] { '0', '0', '0', '0', '0' };

        System.Console.WriteLine(NumIslands(grid));

        grid[0] = new char[5] { '1', '1', '0', '0', '0' };
        grid[1] = new char[5] { '1', '1', '0', '0', '0' };
        grid[2] = new char[5] { '0', '0', '1', '0', '0' };
        grid[3] = new char[5] { '0', '0', '0', '1', '1' };

        System.Console.WriteLine(NumIslands(grid));
    }

    private int NumIslands(char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                    count++;
                search(grid, i, j);
            }
        }
        return count;
    }

    private void search(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            return;

        grid[i][j] = '0';
        search(grid, i + 1, j);
        search(grid, i - 1, j);
        search(grid, i, j + 1);
        search(grid, i, j - 1);
    }
}