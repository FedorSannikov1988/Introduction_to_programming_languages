/*
Напишите программу, для вычисления факториала
*/

int DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InputChislo()
{
    int chislo = DataInput("Введите число для расчета его факториала: ");
    return chislo;
}

int Factorial(int chislo)
{
    int Faktorial = 1;

    for (int i = 1; i <= chislo; i++)
    {
        Faktorial = Faktorial * i;
    }
    return Faktorial;
}

bool ExaminationChislo(int chislo)
{
    if (chislo < 0)
    {
        System.Console.WriteLine($"Введенное число {chislo} меньше 0");
        return false;
    }
    return true;
}

int chislo = InputChislo();

if (ExaminationChislo(chislo))
{
  System.Console.WriteLine($"{Factorial(chislo)}");
}