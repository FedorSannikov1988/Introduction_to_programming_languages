/*
Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.

Пример:
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int DataInputInt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Int32 !");
}

int[] DataInputIntArray(int Nambers)
{
    int[] ReadAray = new int[Nambers];

    for (int i = 0; i < Nambers; i++)
    {
        ReadAray[i] = DataInputInt($"Введите число #{i + 1}: ");
    }
    return ReadAray;
}

bool ExaminationInputNamber(int Chislo)
{
    if (Chislo == 0)
    {
        System.Console.WriteLine(
            "Согласно условию задачи пользователь должен ввести количество чисел больше 0"
        );
        return false;
    }

    if (Chislo < 0)
    {
        System.Console.WriteLine("Количество вводимых чисел не может быть меньше нуля");
        return false;
    }

    return true;
}

int Calculation(int[] array, int nambers)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > nambers)
        {
            count++;
        }
    }

    return count;
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Quantity = DataInputInt("Введите количество чисел которое необходимо ввести для сравнения: ");

if (ExaminationInputNamber(Chislo: Quantity))
{
    int[] ArrayNambers = DataInputIntArray(Nambers: Quantity);

    System.Console.WriteLine("Вы ввели следующие числа: ");

    PrintIntArray(array: ArrayNambers);

    int NamberСompare = DataInputInt("Введите число c которым необходимо сравнить ранее введенные числа: ");

    int СountСompare = Calculation(array: ArrayNambers, nambers: NamberСompare);

    System.Console.WriteLine($"Количество чисел более того числа с которым сравнивают {СountСompare}");
}

System.Console.Read();