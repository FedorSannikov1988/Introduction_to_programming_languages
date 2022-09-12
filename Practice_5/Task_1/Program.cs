/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна -20.
*/

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] GenerationIntRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
    int[] array = new int[Dimension];

    for (int i = 0; i < Dimension; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom);
    }
    return array;
}

int SummElementArray(int[] array)
{
    int Summa = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Summa = Summa + array[i];
    }
    return Summa;
}

bool ExaminationDimensionArray(int Chislo)
{
    if (Chislo == 0)
    {
        System.Console.WriteLine("Размерность массива не должна быть равна нулю");
        return false;
    }

    if (Chislo < 0)
    {
        System.Console.WriteLine("Размерность массива не должна быть меньше нуля");
        return false;
    }

    return true;
}

bool ExaminationMinMaxRandom(int MinRandom, int MaxRandom)
{
    if (MinRandom > 0)
    {
        System.Console.WriteLine(
            "Нижний предел интервала в котором генерируются случайные числа должен быть меньше нуля или равен ему"
        );

        return false;
    }

    if (MaxRandom < 0)
    {
        System.Console.WriteLine(
            "Верхний предел интервала в котором генерируются случайные числа должен быть больше нуля или равен ему"
        );
        return false;
    }
    if (MinRandom == MaxRandom)
    {
        System.Console.WriteLine(
            "Верхний и нижний предел интервала в котором генерируются случайные числа не должен быть равны)"
        );
        return false;
    }

    return true;
}

System.Console.WriteLine(
    "Данная программа находит сумму отрицательных и положительных элементов массива"
);

int Razmernost = InputNamber("Введите размерность массива: ");

int MinRandomNamber = InputNamber(
    "Введите нижний предел интервала в котором генерируются случайные числа: "
);

int MaxRandomNamber = InputNamber(
    "Введите верхний предел интервала в котором генерируются случайные числа: "
);

if (
    ExaminationDimensionArray(Chislo: Razmernost)
    && ExaminationMinMaxRandom(MinRandom: MinRandomNamber, MaxRandom: MaxRandomNamber)
)
{
    int[] RandomArray = GenerationIntRandomArray(MinRandom: MinRandomNamber, MaxRandom: MaxRandomNamber, Dimension:Razmernost);

    System.Console.WriteLine("Сгенерированный массив из случайных чисел:");

    PrintIntArray(array: RandomArray);

    System.Console.WriteLine($"Сумма элементов массива {SummElementArray(array: RandomArray)}");
}

Console.ReadLine();