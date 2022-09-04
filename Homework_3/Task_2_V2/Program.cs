/*
Напишите программу, которая принимает
на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

const int XKOORD = 0;
const int YKOORD = 1;
const int ZKOORD = 2;

double DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] InputKoord()
{
    double[] MassCoord = new double[3];
    MassCoord[XKOORD] = DataInput("Введите координату X: ");
    MassCoord[YKOORD] = DataInput("Введите координату Y: ");
    MassCoord[ZKOORD] = DataInput("Введите координату Z: ");
    return MassCoord;
}

double Square(double chislo)
{
    return (chislo * chislo);
}

/*
//метод Ньютона
//Понял что мне нужно искать именного его исходя из этой статьи: 
//https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D1%82%D0%BE%D0%B4_%D0%9D%D1%8C%D1%8E%D1%82%D0%BE%D0%BD%D0%B0#%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC
//Алгорит взял отсюда (ну очень лень было писать): 
//https://www.cyberforum.ru/csharp-beginners/thread2235689.html
*/
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
            + Square(MassCoordPoint1[ZKOORD] - MassCoordPoint2[ZKOORD])
    );
}

System.Console.WriteLine("Введите координаты первой точки:");
double[] MassCoordPoint1 = InputKoord();

System.Console.WriteLine("Введите координаты второй точки:");
double[] MassCoordPoint2 = InputKoord();

System.Console.WriteLine(
    $"Расстояние между двумя точками: {CalculationLength(MassCoordPoint1, MassCoordPoint2):f6}"
);