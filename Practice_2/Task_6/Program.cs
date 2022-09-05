/*
Напишите программу, которая выводит 
случайное число из отрезка [10, 9999] и
показывает наибольшую цифру числа.
Пример:
7812 -> 8
1213-> 3
845 -> 8
*/

int FaundMaxNamberinChislo(int Chislo)
{
    //контейнер для того что бы сохранить исходное число
    int inChislo = Chislo;
    int MaX = inChislo % 10;
    int OsT = 0;

    while (inChislo != 0)
    {
        inChislo = inChislo / 10;
        OsT = inChislo % 10;
        if (OsT > MaX)
        {
            MaX = OsT;
        }
    }
    return MaX;
}

int RandNumber = new Random().Next(10, 10000);

System.Console.WriteLine($"Случайное число: {RandNumber}");

System.Console.WriteLine($"Наибольшая цифра случайного числа: {FaundMaxNamberinChislo(RandNumber)}");