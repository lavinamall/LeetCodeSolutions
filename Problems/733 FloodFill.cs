using System.Data;
using System.Runtime.ConstrainedExecution;

public class MatrixFloodFill
{

    public void Test()
    {
        int[][] image = new int[3][];
        image[0] = new int[3] { 1, 1, 1 };
        image[1] = new int[3] { 1, 1, 0 };
        image[2] = new int[3] { 1, 0, 1 };

        int[][] result = FloodFill(image, 1, 1, 2);

        foreach(var v in result)
            foreach(var c in v)
                System.Console.Write($"{c},");
    }

    private int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] == color)
            return image;

        fill(image, sr, sc, image[sr][sc], color);

        return image;
    }

    private void fill(int[][] image, int sr, int sc, int sourceColor, int color)
    {
        if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length ||
           image[sr][sc] != sourceColor)
        {
            return;
        }

        image[sr][sc] = color;

        fill(image, sr - 1, sc, sourceColor, color); //top
        fill(image, sr + 1, sc, sourceColor, color); // bottom
        fill(image, sr, sc + 1, sourceColor, color); // right
        fill(image, sr, sc - 1, sourceColor, color); //left

    }
}