/*
Напишите программу, которая на вход 
принимает два числа и проверяет,
 является ли первое число квадратом второго
*/

int Prompt(string message)
{
System.Console.Write(message);
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

System.Console.WriteLine("Программа определяет является первое число квадратом второго");
float ValueA = Prompt("Введите число №1: ");
float ValueB = Prompt("Введите число №2: ");

if ( (ValueA * ValueA) == ValueB )
{
    System.Console.Write($"Число {ValueA} является квадаратом {ValueB}");
}
else
{
   System.Console.Write($"Число {ValueA} НЕ является квадаратом {ValueB}"); 
}