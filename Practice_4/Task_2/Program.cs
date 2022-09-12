/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
Пример:
[1,0,1,1,0,1,0,0]
*/

int[] GenerationDickretArray(int Dimension)
{
    int[] array = new int[Dimension];

    for (int i = 0; i < Dimension; i++)
    {
        array[i] = new Random().Next(0, 2);
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

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine(
    "Данная программа выводит массив элементов заполненный нулями и единицами в случайном порядке."
);

int Razmernost = InputNamber("Введите размерность массива: ");

if (ExaminationDimensionArray(Razmernost))
{
    System.Console.WriteLine("Массив элементов заполненный нулями и единицами в случайном порядке:");
    
    PrintIntArray(GenerationDickretArray(Razmernost));
}

Console.ReadLine();