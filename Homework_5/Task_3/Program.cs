/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и
минимальным элементов массива.

Пример:
[3, 7.4, 22.3, 2, 78] -> 76
*/

double[] CreateDoubleRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
    double[] array = new double[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f4}\t");
    }
    System.Console.WriteLine();
}

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ExaminationNamber(int Chislo)
{
    if (Chislo == 0)
    {
        System.Console.WriteLine(
            "Размерность генерируемого массива случайных чисел не может быть равна нулю"
        );
        return false;
    }

    if (Chislo < 0)
    {
        System.Console.WriteLine(
            "Размерность генерируемого массива случайных чисел не может быть меньше нуля"
        );
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

(double, double, double) DifferenceMaxMin(double[] array)
{
    double MaX = array[0];

    double MiN = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaX)
        {
            MaX = array[i];
        }

        if (array[i] < MiN)
        {
            MiN = array[i];
        }
    }

    double Difference = 0;

    if (MaX < 0 && MiN < 0)
    {
        Difference = MiN - MaX;
    }
    
    Difference = MaX - MiN;

    return (MaX, MiN, Difference);
}

int Razmernost = InputNamber(
    "Введите размерность генерируемого массива состоящего из случайных чисел: "
);

int MinRandomNamber = InputNamber(
    "Введите нижний предел интервала в котором генерируются случайные числа: "
);

int MaxRandomNamber = InputNamber(
    "Введите верхний предел интервала в котором генерируются случайные числа: "
);

if (
    ExaminationNamber(Chislo: Razmernost)
    && ExaminationMinMaxRandom(MinRandom: MinRandomNamber, MaxRandom: MaxRandomNamber)
)
{
    double[] RandomArray = CreateDoubleRandomArray(
        Dimension: Razmernost,
        MinRandom: MinRandomNamber,
        MaxRandom: MaxRandomNamber
    );

    System.Console.WriteLine("Сгенерированный массив случайных чисел:");

    PrintDoubleArray(array: RandomArray);

    (double MaX, double MiN, double Difference) = DifferenceMaxMin(array: RandomArray);

    System.Console.WriteLine($"Максимальный элемент в массиве {MaX:f4}");

    System.Console.WriteLine($"Минимальный элемент в массиве {MiN:f4}");

    System.Console.WriteLine(
        $"Разница между максимальным и минимальным элементом массива {Difference:f4}"
    );
}

System.Console.Read();