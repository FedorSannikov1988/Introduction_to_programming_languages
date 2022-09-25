/*
Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

bool ExaminationPossibilityMultiply(int namberColumnMatrixA, int namberLineMatrixB)
{
    if (namberColumnMatrixA != namberLineMatrixB)
    {
        System.Console.WriteLine("Размерности данных матриц не позволяют совершить операцию умножения");
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

int[,] MultiplyMatrixAandB(int[,] MatrixA, int[,] MatrixB)
{
    int LineResultMatrix = MatrixA.GetLength(0);

    int ColumnResultMatrix = MatrixB.GetLength(1);

    int NamberElementLineAOrColumnB = MatrixA.GetLength(1);
        
    int[,] ResultMultiplyAandB = new int[LineResultMatrix, ColumnResultMatrix];

    for (int i = 0; i < LineResultMatrix; i++)
    {
        for (int j = 0; j < ColumnResultMatrix; j++)
        {
            for (int l = 0; l < NamberElementLineAOrColumnB; l++)
            {
                ResultMultiplyAandB[i,j] +=  MatrixA[i,l] * MatrixB[l,j];
            }
        }
    }
    
    return ResultMultiplyAandB;
}

int MaximumRandomVariable = InputDataInt("Введите верхний придел генерации случайных чисел в перемножаемых матрицах А и B: ");

int MinimumRandomVariable = InputDataInt("Введите нижний придел генерации случайных чисел в перемножаемых матрицах А и B: ");

int NamberLineMatrixA = InputDataInt("Введите количество строк в генерируемой матрице А: ");

int NamberColumnMatrixA = InputDataInt("Введите количество столбцов в генерируемой матрице А: ");

int NamberLineMatrixB = InputDataInt("Введите количество строк в генерируемой матрице B: ");

int NamberColumnMatrixB = InputDataInt("Введите количество столбцов в генерируемой матрице B: ");

if (
    ExaminationPossibilityMultiply(
                  NamberColumnMatrixA,
                  NamberLineMatrixB)
    && 
    ExaminationMaximumMinimumRandomLimit(
                    MinimumRandomVariable, 
                    MaximumRandomVariable)
    )
{
    int[,] MatrixARandomInt = CreateMatrixRandomInt(
    NamberLineMatrixA, NamberColumnMatrixA,
    MinimumRandomVariable, MaximumRandomVariable   );

    int[,] MatrixBRandomInt = CreateMatrixRandomInt(
    NamberLineMatrixB, NamberColumnMatrixB,
    MinimumRandomVariable, MaximumRandomVariable   );

    System.Console.WriteLine("Сгенерированная матрица А:");

    PrintConsoleIntMatrix(MatrixARandomInt);

    System.Console.WriteLine("Сгенерированная матрица B:");

    PrintConsoleIntMatrix(MatrixBRandomInt);  

    System.Console.WriteLine("Произведение матриц А х B:");

    int[,] ResultMultiplyAandB = MultiplyMatrixAandB(MatrixA:MatrixARandomInt , MatrixB:MatrixBRandomInt);

    PrintConsoleIntMatrix(ResultMultiplyAandB);
}

System.Console.Read();