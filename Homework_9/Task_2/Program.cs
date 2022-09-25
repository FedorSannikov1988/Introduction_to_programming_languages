/*
Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

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

int FindSummaRecursion(int start, int stop)
{
    if (start == stop)
    {
        return start;
    }

    return (start + FindSummaRecursion(start + 1, stop));
}

bool ExaminationStartandStopNumbers(int start, int stop)
{
    if ((start > stop) || (start == stop) || (start < 0) || (stop < 0))
    {
        System.Console.WriteLine("Введенные значения M и/или N не соответствуют условию задачи");
        return false;
    }
    return true;
}

System.Console.WriteLine(
    "Данная программа находит сумму натуральных чисел в промежутке от M до N по средством рекурсии"
);

int Start = InputDataInt("Введите N: ");

int Stop = InputDataInt("Введите M: ");

if (ExaminationStartandStopNumbers(Start, Stop))
{
    int Summa = FindSummaRecursion(Start, Stop);

    System.Console.WriteLine($"Сумма элементов от {Start} до {Stop} равна {Summa}");
}

System.Console.Read();