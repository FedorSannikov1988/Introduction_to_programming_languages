/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452 -> 11
82 -> 10
9012 -> 12
*/

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummNamber(int Chislo)
{
    int Ost = 0;
    int Summ = 0;
    int ByffChislo = Chislo;

    while (ByffChislo != 0)
    {
        Ost = ByffChislo % 10;
        Summ = Ost + Summ;
        ByffChislo = ByffChislo / 10;
    }
    return Summ;
}

int Namber = InputNamber("Введите число сумму цифр в котором нужно найти: ");

System.Console.WriteLine($"Сумма цифр в ранее введенном числе {Namber} равна {SummNamber(Chislo:Namber)}");

System.Console.Read();