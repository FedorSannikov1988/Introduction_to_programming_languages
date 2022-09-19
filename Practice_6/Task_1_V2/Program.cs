/*
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)

Пример:
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
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

bool ExaminationMaximumMinimumRandomLimit(int minimumRandom, int maximumRandom)
{
    if (minimumRandom == maximumRandom)
    {
        System.Console.WriteLine(
            "Минимальный и максимальный генерируемый элементы массива случайных чисел не должны быть равны друг другу"
        );
        return false;
    }

    if (minimumRandom > maximumRandom)
    {
        System.Console.WriteLine(
            "Минимальный элемент массива случайных чисел не должен быть больше максимального"
        );
        return false;
    }

    return true;
}

bool ExaminationElementArray(int elementArray)
{
    if (elementArray == 1)
    {
        System.Console.WriteLine(
            "Переворачивать массив с количеством элементов меньше двух не имеет смысла"
        );
        return false;
    }

    if (elementArray == 0)
    {
        System.Console.WriteLine("Количество элементов в массиве не может быть равно нулю");
        return false;
    }

    if (elementArray < 0)
    {
        System.Console.WriteLine("Количество элементов в массиве не может быть меньше нуля");
        return false;
    }
    return true;
}

void PrintConsoleDoubleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

//Куда лучше чем я придумал !

int[] TurnOverArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        var temp = array[i];
        array[i] = array[array.Length - (i + 1)];
        array[array.Length - (i + 1)] = temp;
    }
    return array;
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

int AmountElementArrayVariable = InputDataInt(
    "Введите количество элементов в генерируемом массиве: "
);

int MinimumRandomVariable = InputDataInt("Введите нижний придел генерации случайных чисел: ");

int MaximumRandomVariable = InputDataInt("Введите верхний придел генерации случайных чисел: ");

if (
    ExaminationElementArray(AmountElementArrayVariable)
    && ExaminationMaximumMinimumRandomLimit(MinimumRandomVariable, MaximumRandomVariable)
)
{
    int[] ArrayRandomInt = CreateIntRandomArray(
        AmountElementArrayVariable,
        MinimumRandomVariable,
        MaximumRandomVariable
    );

    System.Console.WriteLine("Сгенерированный массив чисел:");

    PrintConsoleDoubleArray(ArrayRandomInt);

    int[] TurnArrayRandomInt = TurnOverArray(ArrayRandomInt);

    System.Console.WriteLine("Перевернутый массив чисел:");

    PrintConsoleDoubleArray(TurnArrayRandomInt);
}

System.Console.Read();
