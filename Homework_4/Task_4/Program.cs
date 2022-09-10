/*
Напишите программу, которая задаёт массив из 8 элементов случайными числами
и выводит их на экран. Также ищет второй максимум (число меньше максимального
элемента, но больше всех остальных)

Пример:
8 1 2 4 4 5 3 1 -> 5
1 2 6 9 8 1 1 1 -> 8
2 1 2 1 1 1 1 1 -> 1
1 2 1 2 1 1 1 1 -> 1
1 2 3 4 5 6 7 8 -> 7
1 2 3 4 5 6 8 7 -> 7
*/

const int MAX1 = 0;
const int MAX2 = 1;

double[] CreateRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
    double[] array = new double[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f1}\t");
    }
    System.Console.WriteLine();
}

double[] FaundOneAndTwoMax(double[] array)
{
    double[] OneAndTwoMax = new double[2];

    if (array[0] > array[1])
    {
        OneAndTwoMax[MAX1] = array[0];
        OneAndTwoMax[MAX2] = array[1];
    }
    else
    {
        OneAndTwoMax[MAX1] = array[1];
        OneAndTwoMax[MAX2] = array[0];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > OneAndTwoMax[MAX1])
        {
            OneAndTwoMax[MAX2] = OneAndTwoMax[MAX1];
            OneAndTwoMax[MAX1] = array[i];
        }
        //---
        //в услловии ниже OneAndTwoMax[MAX1] != array[i] равноценно OneAndTwoMax[MAX1] > array[i]
        //правда тэстировал только с OneAndTwoMax[MAX1] != array[i]
        if (array[i] > OneAndTwoMax[MAX2] && OneAndTwoMax[MAX1] != array[i])
        {
            OneAndTwoMax[MAX2] = array[i];
        }
    }
    return OneAndTwoMax;
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

int Razmernost = InputNamber(
    "Введите размерность генерируемого массива состоящего из случайных чисел: "
);

if (ExaminationNamber(Chislo: Razmernost))
{
    double[] RandomArray = CreateRandomArray(Razmernost, 1, 100);

    System.Console.WriteLine("Сгенерированный массив случайных чисел:");

    PrintArray(array: RandomArray);

    double[] TwoMaX = FaundOneAndTwoMax(array: RandomArray);

    System.Console.Write($"Максимум №1: {TwoMaX[MAX1]:f1} Максимум №2: {TwoMaX[MAX2]:f1}");
}

System.Console.Read();