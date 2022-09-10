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

bool ExaminationNamber(int Chislo)
{
    if (Chislo == 0)
    {
        System.Console.WriteLine("Введенное число равно нулю и искать сумму его элементов не имет смысла");
        return false;
    }

        if ( (0 < Chislo) && (Chislo < 10) )
    {
        System.Console.WriteLine("Введенное число состоит из одной цифры и искать сумму его элементов не имет смысла");
        return false;
    }

        if (Chislo < 0)
    {
        System.Console.WriteLine("Введенное число меньше нуля что не соответствует условию задачи");
        return false;
    }

    return true;

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

if (ExaminationNamber(Chislo:Namber))
{
    System.Console.WriteLine($"Сумма цифр в ранее введенном числе {Namber} равна {SummNamber(Chislo: Namber)}");
}

System.Console.Read();