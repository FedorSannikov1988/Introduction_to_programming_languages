/*
Сформировать массив четной длины с парами элементов,
каждого элемента должно быть в паре.

Пример:
1,1,2,3,3,2,4,5,4,5
*/

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] CreateHonestArray(int Dimension)
{
    int[] array = new int[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1;
    }
    return array;
}

bool ExaminationDimensionHonestArray(int Chislo)
{
    if (Chislo % 2 != 0)
    {
        System.Console.WriteLine("Размерность массива должна быть четной");
        return false;
    }

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

//Функция не оптимизирована ! Слишком много new Random().Next(0, array.Length);
//Писалось в спешке ночью (да еще и тежело отлаживалось) !
//Смотри оптимизированный вариант № 2
int[] FillingHonestArray(int[] array)
{
    int rand1 = 0;

    int rand2 = 0;

    int flag = 1;

    for (int i = 0; i < array.Length / 2; i++)
    {
        while (rand1 == rand2)
        {
            rand1 = new Random().Next(0, array.Length);
            rand2 = new Random().Next(0, array.Length);
        }

        flag = 0;

        while (flag == 0)
        {
            if ((array[rand1] == -1) && (array[rand2] == -1) && (rand1 != rand2))
            {
                array[rand1] = i + 1;

                array[rand2] = i + 1;

                flag = 1;
            }
            rand1 = new Random().Next(0, array.Length);
            rand2 = new Random().Next(0, array.Length);
        }
    }
    return array;
}

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine(
    "Данная программа генерирует массив четной длины с парами элементов начиная с 1-ого"
);

int Razmernost = InputNamber(
    "Введите размерность массива в котором каждый элементы должны иметь пару: "
);

if (ExaminationDimensionHonestArray(Chislo: Razmernost))
{
    System.Console.WriteLine("Сгенерированный массив из парных элементов:");

    PrintIntArray(array: FillingHonestArray(array: CreateHonestArray(Dimension: Razmernost)));
}

System.Console.Read();