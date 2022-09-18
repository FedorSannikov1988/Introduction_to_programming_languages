/*
Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
Затем из первой суммы (с максимумами) вычтите вторую сумму (с минимумами).

Пример:
1 2 3
3 4 5

3+5=8, 1+2+3=6, 8-6=2
*/

int[,] CreateIntMatrixRandom(int LineMatrix, int ColumnMatrix, int MinRandom, int MaxRandom)
{
    int[,] matrix = new int[LineMatrix, ColumnMatrix];

    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[line, column] = new Random().Next(MinRandom, MaxRandom + 1);
        }
    }
    return matrix;
}

int[] SearchLineMax(int[,] matrix)
{
    int[] MaximumLine = new int[matrix.GetLength(0)];

    int MaximumLineVariable = 0;

    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        MaximumLineVariable = matrix[line, 0];

        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (MaximumLineVariable < matrix[line, column])
            {
                MaximumLineVariable = matrix[line, column];
            }
        }

        MaximumLine[line] = MaximumLineVariable;
    }
    return MaximumLine;
}

int[] SearchColumnMin(int[,] matrix)
{
    int[] MinimumColumn = new int[matrix.GetLength(1)];

    int MinimumColumnVariable = 0;

    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        MinimumColumnVariable = matrix[0, column];

        for (int line = 0; line < matrix.GetLength(0); line++)
        {
            if (MinimumColumnVariable > matrix[line, column])
            {
                MinimumColumnVariable = matrix[line, column];
            }
        }

        MinimumColumn[column] = MinimumColumnVariable;
    }
    return MinimumColumn;
}

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

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

bool ExaminationDimensionMattress(int LineMatrix, int ColumnMatrix)
{
    if (LineMatrix < 2 || ColumnMatrix < 2)
    {
        System.Console.WriteLine("Минимальная размерность двумерной матрицы 2х2");
        return false;
    }

    return true;
}

bool ExaminationMinMaxRandom(int MinRandom, int MaxRandom)
{
    if (MinRandom == MaxRandom)
    {
        System.Console.WriteLine(
            "Минимальный и максимальный генерируемый элементы матрицы случайных чисел не должны быть равны друг другу"
        );
        return false;
    }

    if (MinRandom > MaxRandom)
    {
        System.Console.WriteLine(
            "Минимальный элемент матрицы случайных чисел не должен быть больше максимального"
        );
        return false;
    }

    if (MinRandom < 0)
    {
        System.Console.WriteLine(
            "Минимальный элемент матрицы случайных чисел не должен быть меньше нуля согласно условию задачи"
        );
        return false;
    }

    return true;
}

int DataInputInt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Int32 !");
}

int SymmaIntArray(int[] array)
{
    int Symma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Symma = Symma + array[i];
    }
    return Symma;
}

int LineMatrix = DataInputInt("Введите количество строк в матрице: ");

int ColumnMatrix = DataInputInt("Введите количество столбцов в матрице: ");

int MinRandom = DataInputInt("Введите нижний придел генерации случайных чисел: ");

int MaxRandom = DataInputInt("Введите верхний придел генерации случайных чисел: ");

if (
    ExaminationDimensionMattress(LineMatrix: LineMatrix, ColumnMatrix: ColumnMatrix)
    && ExaminationMinMaxRandom(MinRandom: MinRandom, MaxRandom: MaxRandom)
)
{
    int[,] RandomMatrix = CreateIntMatrixRandom(
        LineMatrix: LineMatrix,
        ColumnMatrix: ColumnMatrix,
        MinRandom: MinRandom,
        MaxRandom: MaxRandom
    );

    System.Console.WriteLine("Сгенерированная матрица:");

    PrintIntMatrix(matrix: RandomMatrix);

    int[] LineMax = SearchLineMax(matrix: RandomMatrix);

    System.Console.WriteLine("Найденные максимумы в каждой строчке:");

    PrintIntArray(array: LineMax);

    int SymmaLineMax = SymmaIntArray(array: LineMax);

    System.Console.WriteLine($"Сумма найденных максимумов в каждой строчке: {SymmaLineMax}");

    int[] ColumnMin = SearchColumnMin(matrix: RandomMatrix);

    System.Console.WriteLine("Найденные минимумы в каждой колонке:");

    PrintIntArray(array: ColumnMin);

    int SymmaColumnMin = SymmaIntArray(array: ColumnMin);

    System.Console.WriteLine($"Сумма найденных минимумов в каждой колонке: {SymmaColumnMin}");

    int Difference = SymmaLineMax - SymmaColumnMin;

    System.Console.WriteLine(
        $"Разница между суммой максимумов в каждой строчке и суммой минимумов в каждом столбце: {Difference}"
    );
}

System.Console.Read();