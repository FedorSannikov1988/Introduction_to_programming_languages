/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
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
    if (lineMatrix < 2 || columnMatrix < 2 || lineMatrix == columnMatrix)
    {
        System.Console.WriteLine("Введённая размерность матрицы не соответствует условию задачи");
        System.Console.WriteLine("Матрица не должна быть меньше размерности 2х2");
        System.Console.WriteLine("Матрица должна быть прямоугольной (количество строк и столбцов не должно быть равно друг другу)");
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

void PrintConsoleIntArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

double[] SearchSummaForAllLineMatrix(int[,] matrix)
{
    double[] LineSummaAllElement = new double[matrix.GetLength(0)];

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        LineSummaAllElement[j] = LineSumma(matrix , line:j);
    }
    return LineSummaAllElement;
}

double LineSumma(int[,] matrix, int line)
{
        double LineSummaElement = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           LineSummaElement = LineSummaElement + matrix[line, i];
        }

        return LineSummaElement;
}

int SearchNamberLineMatrixWithSmallSumma(double[] arraySummaElementLineMatrix)
{
    double NamberLineMatrixWithSmallSumma = arraySummaElementLineMatrix[0];

    int NamberLine = 0;

    for (int i = 0; i < arraySummaElementLineMatrix.Length; i++)
    {
        if (arraySummaElementLineMatrix[i] < NamberLineMatrixWithSmallSumma)
        {
            NamberLineMatrixWithSmallSumma = arraySummaElementLineMatrix[i];

            NamberLine = i;
        }
    }
    return (NamberLine + 1);
}

int LineMatrixVariable = InputDataInt("Введите количество строк в генерируемой матрице: ");

int ColumnMatrixVariable = InputDataInt("Введите количество столбцов в генерируемой матрице: ");

int MaximumRandomVariable = InputDataInt("Введите верхний придел генерации случайных чисел: ");

int MinimumRandomVariable = InputDataInt("Введите нижний придел генерации случайных чисел: ");

if (
    ExaminationDimensionMattress(
                LineMatrixVariable, 
                ColumnMatrixVariable)
    && 
    ExaminationMaximumMinimumRandomLimit(
                    MinimumRandomVariable, 
                    MaximumRandomVariable)
    )
{
    int[,] MatrixRandomInt = CreateMatrixRandomInt(
    LineMatrixVariable, ColumnMatrixVariable,
    MinimumRandomVariable, MaximumRandomVariable  );

    System.Console.WriteLine("Сгенерированная матрица:");

    PrintConsoleIntMatrix(MatrixRandomInt);
    
    System.Console.WriteLine("Cумма элементов каждой строки сгенерированной матрицы:");
    
    double[] LineSummaElement = SearchSummaForAllLineMatrix(MatrixRandomInt);
    
    PrintConsoleIntArray(LineSummaElement);

    int NamberLineMatrixWithSmallSumma = SearchNamberLineMatrixWithSmallSumma(LineSummaElement);
    
    System.Console.WriteLine($"Строка (первая по счету сверху) в сгенерированной матрице с наименьшей суммой элементов: {NamberLineMatrixWithSmallSumma}");
}

System.Console.Read();