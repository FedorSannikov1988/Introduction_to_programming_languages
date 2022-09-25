/*
Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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

void GenerateNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    System.Console.Write($"{number} ");
    GenerateNumbers(number - 1);
}

bool ExaminationStartNumbers(int number)
{
    if (number <= 0)
    {
        System.Console.WriteLine("Введенное число не соотвевует условию задачи");
        return false;
    }

    return true;
}

System.Console.WriteLine(
    "Данная программа выводит все натуральные числа в промежутке от N до 1 по средством рекурсии"
);

int Start = InputDataInt("Введите N: ");

if (ExaminationStartNumbers(Start))
{
    GenerateNumbers(Start);
}

System.Console.Read();