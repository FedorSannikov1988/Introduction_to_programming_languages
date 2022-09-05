/*
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
*/

//Обратная ситуация: использовал алгоритм из домашней работы №3

const int XKOORD = 0;
const int YKOORD = 1;

double DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] InputKoord()
{
    double[] MassCoord = new double[2];
    MassCoord[XKOORD] = DataInput("Введите координату X: ");
    MassCoord[YKOORD] = DataInput("Введите координату Y: ");
    return MassCoord;
}

double Square(double chislo)
{
    return (chislo * chislo);
}

//метод Ньютона
double SquareRoot(double number)
{
    double t;
    double squareRoot = number / 2;
    do
    {
        t = squareRoot;
        squareRoot = (t + (number / t)) / 2;
    } while ((t - squareRoot) != 0);

    return squareRoot;
}

double CalculationLength(double[] MassCoordPoint1, double[] MassCoordPoint2)
{
    return SquareRoot(
        Square(MassCoordPoint1[XKOORD] - MassCoordPoint2[XKOORD])
            + Square(MassCoordPoint1[YKOORD] - MassCoordPoint2[YKOORD])
    );
}

System.Console.WriteLine("Введите координаты первой точки:");
double[] MassCoordPoint1 = InputKoord();

System.Console.WriteLine("Введите координаты второй точки:");
double[] MassCoordPoint2 = InputKoord();

System.Console.WriteLine(
    $"Расстояние между двумя точками: {CalculationLength(MassCoordPoint1, MassCoordPoint2):f2}"
);