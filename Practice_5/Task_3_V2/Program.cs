/*
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.

Пример:
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int PrintIntArrayRecursion(int[] array)
{
    if ( (array.Length - 1) < 0)
    {
        return (1);
    }
    System.Console.Write($"{array[array.Length - 1]}\t");
    return (array[array.Length - 1]);
}

/*
double Proba1(double N)
{
    if (N == 0)
    {
        return 1;
    }
    System.Console.WriteLine($"{N}");
    System.Console.WriteLine("#");
    return (Proba1(N - 1));
}
*/

int DataInput(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Int32 !");
}

int[] CreateIntRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
    int[] array = new int[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom + 1);
    }
    return array;
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
    if (MinRandom < 0)
    {
        System.Console.WriteLine(
            "Нижний предел интервала в котором генерируются случайные числа не должен быть меньше нуля так как нам нужно сгенерировать ряд положительных случайных чисел"
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

    if (MinRandom > MaxRandom)
    {
        System.Console.WriteLine(
            "Верхний предел должен быть больше нижний предела генерации случайных чисел)"
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

bool FindNamber(int[] array, int namber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == namber)
        {
            return true;
        }
    }
    return false;
}

int Razmernost = DataInput(
    "Введите размерность генерируемого массива состоящего из случайных чисел: "
);

int MinRandomNamber = DataInput(
    "Введите нижний предел интервала в котором генерируются случайные числа: "
);

int MaxRandomNamber = DataInput(
    "Введите верхний предел интервала в котором генерируются случайные числа: "
);

int FaundNamber = DataInput(
    "Введите число наличие которого необходимо определить в генерируемом массиве: "
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

    PrintIntArrayRecursion(array: RandomArray);

    System.Console.Write("");

    if (FindNamber(namber: FaundNamber, array: RandomArray))
    {
        System.Console.WriteLine("Искомое число находится в сгенерированном массиве");
    }
    else
    {
        System.Console.WriteLine("Искомое число не находится в сгенерированном массиве");
    }
}

System.Console.Read();