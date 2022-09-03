/*
 Напишите программу, которая выводит случайное число 
 из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

int RandNumber = new Random().Next(10,100);
int byfer1 = RandNumber;
int byfer2 = RandNumber % 10;
int MaX = 0;

while ( byfer1 > 0 )
{
if( byfer2 > MaX ) {MaX = byfer2;}
byfer1 = byfer1 / 10;
byfer2 = byfer1 % 10;
}

//---
System.Console.WriteLine($"Случайное число: {RandNumber}");
System.Console.WriteLine("----*----*----");
System.Console.WriteLine($"Наибольшая из цифр составляющая данное число: {MaX}");