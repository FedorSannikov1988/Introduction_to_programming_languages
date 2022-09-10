/*
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double InputShiclo(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

int InputStepen(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Exponentiation(double shiclo, int stepen)
{
    if (stepen == 0)
    {
        return 0;
    }

    int znak = 1;

    if (stepen < 0)
    {
        znak = -1;
    }

    double ByferForChislo = shiclo;

    for (int i = 1; i < (stepen * znak); i++)
    {
        ByferForChislo = ByferForChislo * shiclo;
    }

    if (stepen < 0)
    {
        return (1 / ByferForChislo);
    }

    return ByferForChislo;
}

System.Console.WriteLine(
    "Данная программа возводит введенное число в степень которая так же вводится с клавиатуры"
);

System.Console.WriteLine("Степень имеет формат int число double");

double namber = InputShiclo("Введите число для возведения в степень: ");

int power = InputStepen("Введите степень в которую необходимо возвести ранее введенное число: ");

System.Console.WriteLine(
    $"Число {namber} в степени {power} равно {Exponentiation(stepen: power, shiclo: namber):f3}"
);

System.Console.Read();