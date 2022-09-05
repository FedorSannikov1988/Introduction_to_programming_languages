/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
Пример:
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

//Использую алгоритм из домашней работы

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

int Square(int chislo)
{
    return (chislo * chislo);
}

void RachetSquareForList(int chislo)
{
    for (int i = 1; i <= chislo; i++)
    {
        System.Console.Write($"{i} ");
    }

    System.Console.WriteLine("");

    for (int i = 1; i <= chislo; i++)
    {
        System.Console.Write($"{Square(i)} ");
    }
}

System.Console.WriteLine(
    "Программа, принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N"
);

int chislo = InputChislo();

if (ExaminationData(chislo))
{
    RachetSquareForList(chislo);
}
else
{
    System.Console.WriteLine($"Введенное число {chislo} не соответствует условию задачи");
    System.Console.WriteLine($"Введенное число 0 или меньше 0");
}