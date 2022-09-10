/*
Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
Пример:
14212 -> нет
23432 -> да
12821 -> да
*/

int DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InputChislo()
{
    int chislo = DataInput("Введите число для проверки: ");
    return chislo;
}

bool ExaminationData(int chislo)
{
    int znak = 1;

    if (chislo < 0)
    {
        znak = -1;
    }

    int byfer = chislo * znak;

    if (byfer < 10)
    {
        System.Console.WriteLine("Число состояцее из одной цифры неможет быть палиндромом");
        return false;
    }

    return true;
}

//Примитивная и простая функция для вычисления степени
int Pow10(int stepen)
{
    int POW10 = 1;

    for (int i = 0; i < stepen; i++)
    {
        POW10 = POW10 * 10;
    }
    return POW10;
}

int TurnNamber(int chislo)
{
    int znak = 1;

    if (chislo < 0)
    {
        znak = -1;
    }

    int byfer1 = chislo * znak;
    int byfer2 = byfer1;
    int ost = 0;
    int turnchislo = 0;

    int count = 0;

    while (byfer1 > 0)
    {
        byfer1 = byfer1 / 10;
        count++;
    }

    for (int i = 0; i < count; i++)
    {
        ost = byfer2 % 10;
        byfer2 = byfer2 / 10;
        turnchislo = turnchislo + (ost * Pow10(count - (i + 1)));
    }
    return (turnchislo * znak);
}

System.Console.WriteLine(
    "Программа, принимает на вход число и проверяет, является число палиндромом или нет."
);
System.Console.WriteLine(
    "Программа, принимает не только положительные, но и отрицательные числа !"
);

int chislo = InputChislo();

if (ExaminationData(chislo))
{
    System.Console.WriteLine($"Развернули введенное число: {TurnNamber(chislo)}");

    if (TurnNamber(chislo) == chislo)
    {
        System.Console.WriteLine($"Введенное число {chislo} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Введенное число {chislo} НЕ является палиндромом");
    }
}