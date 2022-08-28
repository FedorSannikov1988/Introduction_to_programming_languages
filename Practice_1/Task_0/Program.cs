//Задание номер № 0
//Напишите программу, которая на вход принимает 
//число и выдаёт его квадрат (число умноженное на само себя).

System.Console.WriteLine("Введите число ");

string strValue = Console.ReadLine() ?? "0";

int Value = int.Parse (strValue);

int Result = Value * Value;

System.Console.WriteLine($"Квадрат числа {Value} равен {Result}");