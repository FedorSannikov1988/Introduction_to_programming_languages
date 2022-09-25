/*
Задайте значения M и N. Напишите программу, которая выведет
все чётные натуральные числа в промежутке от M до N
с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void PrintNumberEvenNaturalMtoN(int start, int stop)
{
    if (start % 2 != 0)
    {
        start++;
    }

    if (start == stop && stop % 2 == 0)
    {
        System.Console.Write($" {start}; ");

        return;
    }

    if (start > stop)
    {
        return;
    }
    
    System.Console.Write($" {start}; ");

    PrintNumberEvenNaturalMtoN(start + 2, stop);
}

bool ExaminationMandNforPrintNumberEvenNatural(int m, int n)
{
    if ((m < 1) || (n < 1) || (n < m) || (n == m))
    {
        System.Console.WriteLine("Введенные значения m и/или n не соответствуют условию задачи");
        return false;
    }
    return true;
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

System.Console.WriteLine("Данная программа выводит все чётные натуральные числа в промежутке от M до N");

int Start = InputDataInt("Введите число M: ");

int Stop = InputDataInt("Введите число N: ");

if (ExaminationMandNforPrintNumberEvenNatural(Start, Stop))
{
PrintNumberEvenNaturalMtoN(Start, Stop);
}

System.Console.Read();