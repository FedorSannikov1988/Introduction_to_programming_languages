/*
Напишите программу, которая на вход принимает 
число и выдаёт его квадрат (число умноженное на само себя).
*/

int Prompt(string message)
{
System.Console.Write(message);
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

int Value = Prompt("Введите число ");

int Result = Value * Value;

System.Console.WriteLine($"Квадрат числа {Value} равен {Result}");

/*

//System.Console.WriteLine("Пожалуйста введите число ");
System.Console.Write("Пожалуйста введите число ");

string strValue;
strValue = Console.ReadLine() ?? ""; 

//превращаем string в int
int Value = int.Parse (strValue);

int Result = Value * Value;

System.Console.WriteLine($"Квадрат числа {Value} равен {Result}");

*/