/*
Напишите программу, которая заполнит спирально квадратный массив.
*/
void PrintConsoleIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int InputDataInt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int numberInt);
    if (isDigit)
    {
        return numberInt;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Int32 !");
}

bool ExaminationDimensionMattress(int dimensionMattress)
{
    if ((dimensionMattress >= 1) && (dimensionMattress < 2))
    {
        System.Console.WriteLine(
            "Минимальная размерность двумерной матрицы для заполнения её по спирали 2х2"
        );
        return false;
    }

    if (dimensionMattress == 0)
    {
        System.Console.WriteLine("Матрицы с нулевой размерностью не существует");
        return false;
    }

    if (dimensionMattress < 0)
    {
        System.Console.WriteLine("Матрицы с отрицательной размерностью не существует");
        return false;
    }

    return true;
}

int[,] GeneratedSquareMatrix(int dimensionMattress)
{
    int[,] SquareMatrix = new int[dimensionMattress, dimensionMattress];

    int i = 0;
    int j = 0;
    int count = 1;

    while (dimensionMattress != 0)
    {
        int k = 0;
        do {SquareMatrix[i, j++] = count++;} while (++k < dimensionMattress - 1);
        for (k = 0; k < dimensionMattress - 1; k++) {SquareMatrix[i++, j] = count++;}
        for (k = 0; k < dimensionMattress - 1; k++) {SquareMatrix[i, j--] = count++;}
        for (k = 0; k < dimensionMattress - 1; k++) {SquareMatrix[i--, j] = count++;}
        ++i;
        ++j;
        if (dimensionMattress < 2) {dimensionMattress = 0;}
        else {dimensionMattress = dimensionMattress - 2;}
    }
    return SquareMatrix;
}

int DimensionSquareMattress = InputDataInt(
    "Введите размерность квадратной матрицы заполняемой по спирали: ");

if (ExaminationDimensionMattress(DimensionSquareMattress))
{
    System.Console.WriteLine("Сгенерированная матрица:");

    int[,] SquareMatrix = GeneratedSquareMatrix(DimensionSquareMattress);

    PrintConsoleIntMatrix(SquareMatrix);
}

System.Console.Read();