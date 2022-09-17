/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
*/

double DataInputInt(string message)
{
    Console.Write(message);
    bool isDigit = double.TryParse(Console.ReadLine(), out double number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Double !");
}

bool ExaminationСoefficientEquations(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        System.Console.WriteLine("Бесконечное множество решений (прямые совпадают)");
        return false;
    }

    if (k1 == k2)
    {
        System.Console.WriteLine("Не имеет решений (прямые параллельны между собой)");
        return false;
    }

    return true;
}

(double, double) SolvingEquation(double k1, double b1, double k2, double b2)
{
    double X = ((b2 - b1) / (k1 - k2));

    double Y = ((k1 * X) + b1);

    return (X, Y);
}

System.Console.WriteLine("Введите коэффициэнты k1 , k2 , b1 , b2");
System.Console.WriteLine("Для системы уравнений:");
System.Console.WriteLine("Y = k1 * Х + b1");
System.Console.WriteLine("Y = k2 * Х + b2");

System.Console.WriteLine("-------");
double k1 = DataInputInt("k1 = ");
double b1 = DataInputInt("b1 = ");
System.Console.WriteLine("-------");
double k2 = DataInputInt("k2 = ");
double b2 = DataInputInt("b2 = ");
System.Console.WriteLine("-------");

if (ExaminationСoefficientEquations(k1: k1, k2: k2, b1: b1, b2: b2))
{
    (double X, double Y) = SolvingEquation(k1: k1, k2: k2, b1: b1, b2: b2);
    System.Console.WriteLine("Точка пересечения двух прямых");
    System.Console.WriteLine($"X = {X:f3}; Y = {Y:f3};");
}

System.Console.Read();