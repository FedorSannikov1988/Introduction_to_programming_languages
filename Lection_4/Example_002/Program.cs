void PrintIntMatrix(int[,] matrix)
{
    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            System.Console.Write($" {matrix[line, column]} ");
        }

        System.Console.WriteLine();
    }
}

int[,] FillIntMatrixRandom(int[,] matrix, int MinRandom, int MaxRandom)
{
    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[line, column] = new Random().Next(MinRandom, MaxRandom+1);
        }
    }
    return matrix;
}

int[,] matrix = new int[3, 3];

PrintIntMatrix(matrix);

System.Console.WriteLine("----------");

int[,] RandomMatrix = FillIntMatrixRandom(matrix, 0, 5);

PrintIntMatrix(RandomMatrix);