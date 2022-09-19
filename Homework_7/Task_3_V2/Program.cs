/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateMatrixRandomInt(
    int lineMatrix,
    int columnMatrix,
    int minRandomIntNamber,
    int maxRandomIntNamber  )
{
    int[,] createMatrix = new int[lineMatrix, columnMatrix];

    for (int i = 0; i < createMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < createMatrix.GetLength(1); j++)
        {
            createMatrix[i, j] = new Random().Next(minRandomIntNamber, maxRandomIntNamber + 1);
        }
    }
    return createMatrix;
}

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

bool ExaminationDimensionMattress(int lineMatrix, int columnMatrix)
{
    if (lineMatrix < 2 || columnMatrix < 2)
    {
        System.Console.WriteLine("Минимальная размерность двумерной матрицы 2х2");
        System.Console.WriteLine("Меньшая размерность превращает 2-х мерную матрицу в одномерный массив");
        return false;
    }

    return true;
}

bool ExaminationMaximumMinimumRandomLimit(int minimumRandom, int maximumRandom)
{
    if (minimumRandom == maximumRandom)
    {
        System.Console.WriteLine(
            "Минимальный и максимальный генерируемый элементы матрицы случайных чисел не должны быть равны друг другу !"
        );
        return false;
    }

    if (minimumRandom > maximumRandom)
    {
        System.Console.WriteLine(
            "Минимальный элемент матрицы случайных чисел не должен быть больше максимального"
        );
        return false;
    }

    return true;
}

void PrintConsoleDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}; ");
    }
    System.Console.WriteLine();
}

double[] SearchColumnSumma(int[,] matrix)
{
    double[] ColumnSumma = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            ColumnSumma[j] = ColumnSumma[j] + matrix[i, j];
        }
    }
    return ColumnSumma;
}

double[] SearchColumnAverage(int[,] matrix, double[] arrayColumnSumma)
{
    double[] ColumnAverage = new double[matrix.GetLength(1)];

    for (int i = 0; i < arrayColumnSumma.Length; i++)
    {
        ColumnAverage[i] = arrayColumnSumma[i]/matrix.GetLength(0);
    }
    return ColumnAverage;
}

int LineMatrixVariable = InputDataInt("Введите количество строк в генерируемой матрице: ");

int ColumnMatrixVariable = InputDataInt("Введите количество столбцов в генерируемой матрице: ");

int MaximumRandomVariable = InputDataInt("Введите верхний придел генерации случайных чисел: ");

int MinimumRandomVariable = InputDataInt("Введите нижний придел генерации случайных чисел: ");

if (
    ExaminationDimensionMattress(
    LineMatrixVariable, ColumnMatrixVariable)
    && 
    ExaminationMaximumMinimumRandomLimit(
    MinimumRandomVariable, MaximumRandomVariable)
    )
{
    int[,] MatrixRandomInt = CreateMatrixRandomInt(
    LineMatrixVariable, ColumnMatrixVariable,
    MinimumRandomVariable, MaximumRandomVariable  );

    System.Console.WriteLine("Сгенерированная матрица:");

    PrintConsoleIntMatrix(MatrixRandomInt);
    
    System.Console.WriteLine("Cумма элементов каждого столбца сгенерированной матрицы:");
    
    double[] ColumnSumma = SearchColumnSumma(MatrixRandomInt);
    
    PrintConsoleDoubleArray(ColumnSumma);

    System.Console.WriteLine("Cреднее арифметическое элементов для каждого столбца сгенерированной матрицы:");
    
    double[] ColumnAverage = SearchColumnAverage(MatrixRandomInt, ColumnSumma);

    PrintConsoleDoubleArray(ColumnAverage);
}

System.Console.Read();