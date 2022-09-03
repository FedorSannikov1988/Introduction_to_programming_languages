/*
Напишите программу, которая 
принимает на вход трёхзначное число и 
на выходе показывает последнюю цифру этого числа.
*/

System.Console.Write("Введите трехзначное число: ");
string Value = Console.ReadLine() ?? "";
char LastChar = Value [ Value.Length - 1 ];

System.Console.Write(LastChar);