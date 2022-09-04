/*
Напишите программу, которая принимает
на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Основной алгоритм взял с практики но немного его доработал
во второй версии программы Task_2_V2 доработки несколько более 
существенные (к примеру ввел double и нашол функцию 
вычисления корня) и интересные
*/

const int XKOORD = 0;
const int YKOORD = 1;
const int ZKOORD = 2;

int DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputKoord()
{
    int[] MassCoord = new int[3];
    MassCoord[XKOORD] = DataInput("Введите координату X: ");
    MassCoord[YKOORD] = DataInput("Введите координату Y: ");
    MassCoord[ZKOORD] = DataInput("Введите координату Z: ");
    return MassCoord;
}

int Square(int chislo)
{
    return (chislo * chislo);
}

double CalculationLength(int[] MassCoordPoint1, int[] MassCoordPoint2)
{
    return Math.Sqrt(
        Square(MassCoordPoint1[XKOORD] - MassCoordPoint2[XKOORD])
            + Square(MassCoordPoint1[YKOORD] - MassCoordPoint2[YKOORD])
            + Square(MassCoordPoint1[ZKOORD] - MassCoordPoint2[ZKOORD])
    );
}

System.Console.WriteLine("Введите координаты первой точки:");
int[] MassCoordPoint1 = InputKoord();

System.Console.WriteLine("Введите координаты второй точки:");
int[] MassCoordPoint2 = InputKoord();

System.Console.WriteLine(
    $"Расстояние между двумя точками: {CalculationLength(MassCoordPoint1, MassCoordPoint2):f6}"
);
