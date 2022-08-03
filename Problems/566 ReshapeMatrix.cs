public class ReshapeMatrix
{
    private int[][] Reshape(int[][] mat, int row, int col)
    {
        int count = 0;
        int[][] result = new int[row][];

        for (int i = 0; i < row; i++)
            result[i] = new int[col];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                result[count / col][count % col] = mat[i][j];
                count++;
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result[i].Length; j++)
            {
                System.Console.Write(result[i][j]);
            }
            System.Console.WriteLine();
        }

        return result;
    }

    public void Test()
    {
        int[][] mat = new int[2][];
        mat[0] = new int[2]{1,2};
        mat[1] = new int[2]{3,4};

        int row = 4, col = 1;

        Reshape(mat, row, col);
    }

}