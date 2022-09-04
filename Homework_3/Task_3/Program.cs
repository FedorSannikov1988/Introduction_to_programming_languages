/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
Пример:
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/

int DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InputChislo()
{
    int chislo = DataInput("Введите число N: ");
    return chislo;
}

bool ExaminationData(int chislo)
{
    if (chislo <= 0)
    {
        return false;
    }

    return true;
}

int Сube(int chislo)
{
    return (chislo * chislo * chislo);
}

void RachetСubeForList(int chislo)
{
    for (int i = 1; i <= chislo; i++)
    {
        System.Console.Write($"{i} ");
    }

    System.Console.WriteLine("");

    for (int i = 1; i <= chislo; i++)
    {
        System.Console.Write($"{Сube(i)} ");
    }
}

System.Console.WriteLine(
    "Программа, принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N"
);

int chislo = InputChislo();

if (ExaminationData(chislo))
{
    RachetСubeForList(chislo);
}
else
{
    System.Console.WriteLine($"Введенное число {chislo} не соответствует условию задачи");
    System.Console.WriteLine($"Введенное число 0 или меньше 0");
}