/*
Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или
указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет
*/

double[,] CreateMatrixRandomDouble(
    int lineMatrix,
    int columnMatrix,
    int minRandomIntNamber,
    int maxRandomIntNamber         )
{
    double[,] createMatrix = new double[lineMatrix, columnMatrix];

    for (int i = 0; i < createMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < createMatrix.GetLength(1); j++)
        {
            createMatrix[i, j] =
                new Random().Next(minRandomIntNamber, maxRandomIntNamber + 1)
                + new Random().NextDouble();
        }
    }
    return createMatrix;
}

void PrintConsoleDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]:f2} ");
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
        System.Console.WriteLine(
            "Меньшая размерность превращает 2-х мерную матрицу в одномерный массив"
        );
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

bool ExaminationLineAndColumnMattress(int lineMatrix, int columnMatrix)
{
    if (lineMatrix < 1 || columnMatrix < 1)
    {
        System.Console.WriteLine(
            "Отрицательной позиции (отрицательного номера колонки или столбца) или нулевой позиции не существует"
        );
        return false;
    }
    return true;
}

bool ExaminationPositionElementMattress(double[,] matrix, int lineMatrix, int columnMatrix)
{
    if ((lineMatrix > matrix.GetLength(0)) || (columnMatrix > matrix.GetLength(1)))
    {
        return false;
    }
    return true;
}

int LineMatrixVariable = InputDataInt("Введите количество строк в генерируемой матрице: ");

int ColumnMatrixVariable = InputDataInt("Введите количество столбцов в генерируемой матрице: ");

int MaximumRandomVariable = InputDataInt("Введите верхний придел генерации случайных чисел: ");

int MinimumRandomVariable = InputDataInt("Введите нижний придел генерации случайных чисел: ");

if (
    ExaminationDimensionMattress(
    lineMatrix: LineMatrixVariable, 
    columnMatrix: ColumnMatrixVariable)
    && 
    ExaminationMaximumMinimumRandomLimit(
    maximumRandom: MaximumRandomVariable,
    minimumRandom: MinimumRandomVariable)
)
{
    double[,] MatrixRandomDouble = CreateMatrixRandomDouble(
        lineMatrix: LineMatrixVariable,
        columnMatrix: ColumnMatrixVariable,
        minRandomIntNamber: MinimumRandomVariable,
        maxRandomIntNamber: MaximumRandomVariable           );

    PrintConsoleDoubleMatrix(MatrixRandomDouble);

    int PositionElementLine = InputDataInt("Введите строку на которой находится искомый элемент: ");

    int PositionElementColumn = InputDataInt("Введите столбец на котором находится искомый элемент: ");

    if (ExaminationLineAndColumnMattress(
            lineMatrix: PositionElementLine,
            columnMatrix: PositionElementColumn))
    {
        if (ExaminationPositionElementMattress(
                matrix: MatrixRandomDouble,
                lineMatrix: PositionElementLine,
                columnMatrix: PositionElementColumn))
        {
            System.Console.WriteLine(
            $"Matrix[{PositionElementLine},{PositionElementColumn}]={MatrixRandomDouble[PositionElementLine - 1, PositionElementColumn - 1]:f2}"
                                    );
        }
        else {System.Console.WriteLine("Элемента с такими индексами в матрице нет !");}
    }
}

System.Console.Read();