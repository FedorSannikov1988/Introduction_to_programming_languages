﻿/*
Напишите программу вычисления модуля числа.
Примпер:
2 -> 2
-3 -> 3
-7 -> 7
На практике определились что это будет программа/функция вычисления куба (1 : 20) !
*/

//Блок ввода
float ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    float Value = float.Parse(strValue);
    return Value;
}

float Chislo = ZaPRoS("Введите число модуль которого нужно получить: ", 0);

if ( Chislo < 0 )
{
   System.Console.WriteLine($"Модуль числа {Chislo} равен {-1 * Chislo}");
}
//---
else
{
   System.Console.WriteLine($"Модуль числа {Chislo} равен {Chislo}");
}