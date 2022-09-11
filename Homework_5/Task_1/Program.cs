/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

Пример:
[345, 897, 568, 234] -> 2
*/

const int MINRANDOMNAMBER = 100;
const int MAXRANDOMNAMBER = 999;

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

(int, int) CountHonestAndNotHonest(int[] array)
{
    int CountHonest = 0;

    int CountNotHonest = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            CountHonest++;
        }
        else
        {
            CountNotHonest++;
        }
    }

    return (CountHonest, CountNotHonest);
}

System.Console.WriteLine(
    "Данная программа заполняет случайными положительными трёхзначными числами массив и информирует о количесве четных и нечетных чисел в массиве"
);

int Razmernost = InputNamber(
    "Введите размерность генерируемого массива состоящего из случайных чисел: "
);

if (ExaminationNamber(Chislo: Razmernost))
{
    int[] RandomArray = CreateIntRandomArray(
        Dimension: Razmernost,
        MinRandom: MINRANDOMNAMBER,
        MaxRandom: MAXRANDOMNAMBER
    );

    System.Console.WriteLine("Сгенерированный массив случайных чисел:");

    PrintIntArray(array: RandomArray);

    (int NamberHonest, int NamberNotHonest) = CountHonestAndNotHonest(array: RandomArray);

    System.Console.WriteLine(
        $"Количество четных чисел в сгенерированном массиве равно {NamberHonest}"
    );

    System.Console.WriteLine(
        $"Количество не четных чисел в сгенерированном массиве равно {NamberNotHonest}"
    );
}

System.Console.Read();