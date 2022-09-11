/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

Пример:
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
*/

int[] CreateIntRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
    int[] array = new int[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom + 1);
    }
    return array;
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
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
    if (MinRandom >= 0)
    {
        System.Console.WriteLine(
            "Нижний предел интервала в котором генерируются случайные числа должен быть меньше нуля"
        );

        return false;
    }

    if (MaxRandom < 0)
    {
        System.Console.WriteLine(
            "Верхний предел интервала в котором генерируются случайные числа должен быть больше нуля (или на крайний случай равен ему)"
        );
        return false;
    }
    return true;
}

(int, int) SummHonestAndNotHonest(int[] array)
{
    int SummHonest = 0;

    int SummNotHonest = 0;

    for (int i = 1; i <= array.Length; i++)
    {
        if (i % 2 == 0)
        {
            SummHonest = SummHonest + array[i - 1];
        }
        else
        {
            SummNotHonest = SummNotHonest + array[i - 1];
        }
    }

    return (SummHonest, SummNotHonest);
}

System.Console.WriteLine(
    "Данная программа задает одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных и нечетных позициях."
);

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
    int[] RandomArray = CreateIntRandomArray(
        Dimension: Razmernost,
        MinRandom: MinRandomNamber,
        MaxRandom: MaxRandomNamber
    );

    System.Console.WriteLine("Сгенерированный массив случайных чисел:");

    PrintIntArray(array: RandomArray);

    (int SummHonest, int SummNotHonest) = SummHonestAndNotHonest(array: RandomArray);

    System.Console.WriteLine(
        $"Сумма чисел занимающих четных позиции в сгенерированном массиве равна {SummHonest}"
    );

    System.Console.WriteLine(
        $"Сумма чисел занимающих не четных позиции в сгенерированном массиве равна {SummNotHonest}"
    );
}

System.Console.Read();