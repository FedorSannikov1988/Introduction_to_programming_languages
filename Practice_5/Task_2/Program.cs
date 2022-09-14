/*
Напишите программу замены элементов массива:
положительные элементы замените на соответствующие
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

//Прикольная штука (надо ее будет использовать) !
//int.TryParse - реально крутой метод преобразования !
// Нужно запомнить !
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

int[] ChangeSignIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (-1) * array[i];
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

int Razmernost = DataInput(
    "Введите размерность генерируемого массива состоящего из случайных чисел: "
);

int MinRandomNamber = DataInput(
    "Введите нижний предел интервала в котором генерируются случайные числа: "
);

int MaxRandomNamber = DataInput(
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

    PrintIntArray(RandomArray);

    System.Console.WriteLine(
        "Сгенерированный массив случайных чисел после изминения знака его элементов:"
    );

    PrintIntArray(ChangeSignIntArray(RandomArray));
}

System.Console.Read();