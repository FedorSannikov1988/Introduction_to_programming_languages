/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деление.
Пример:
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    bool isNumber = int.TryParse(strValue, out int Value);
    if (isNumber) {return Value;}
    throw new Exception ("Введенные символы невозможно преобразовать в целое число !");
}

int mamber1 = ZaPRoS("Введите число №1: ", 0);
int mamber2 = ZaPRoS("Введите число №2: ", 0);

if (mamber1 >= mamber2)
{
if (mamber1 % mamber2 == 0) 
{System.Console.WriteLine($"Число {mamber1} кратно {mamber2}");}
//---
else 
{System.Console.WriteLine($"Число {mamber1} не кратно {mamber2} остаток от деления {mamber1 % mamber2}");}
}