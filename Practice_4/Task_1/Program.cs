/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Пример:
7 -> 28
4 -> 10
8 -> 36
*/

ulong InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}

ulong SumNumbers(ulong number)
{
    ulong Sum = 0;
    for (ulong i = 1; i <= number; i++)
    {
        Sum = Sum + i;
    }
    return Sum;
}

ulong SumNumbersGauss(ulong number)
{
    return (((number + 1) * number)/ 2);
}

System.Console.WriteLine("Данная программа принимает на вход число А и выдаёт сумму чисел от 1 до А.");

ulong Namber = InputNamber("Введите число А: ");

System.Console.WriteLine($"Сумма рассчитанная через цикл for: {ulong SumNumbers(number:Namber)} равна {SumNumbersGauss(number:Namber)}");

System.Console.Read();