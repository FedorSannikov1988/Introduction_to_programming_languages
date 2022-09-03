/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
Пример:
456 -> 6
782 -> 2
918 -> 8
*/

//Упростил домашнюю работу до крайности !

int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    bool isNumber = int.TryParse(strValue, out int Value);
    if (isNumber) {return Value;}
    //исключение для if
    throw new Exception ("Введенные символы невозможно преобразовать в целое число типа int !");
}
//Устанавливаем правила ввода для пользователя 
System.Console.WriteLine("Данная программа на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа");
System.Console.WriteLine("Нумерация цифр в числе идет слева направо.");

int chislo = ZaPRoS("Пожалуйста введите трехзначное число: ", 0);

//---
if ( chislo > 99 && chislo < 1000 )
{System.Console.WriteLine($"Последняя цифра {chislo%10} введенного Вами числа {chislo}.");}

//---
if ( chislo > 1000 )
{System.Console.WriteLine($"Введенное Вами число {chislo} четырехзначное или больше!");}

//---
if ( chislo >= 0 && chislo < 99 )
{System.Console.WriteLine($"Введенное Вами число {chislo} двухзначное или меньше!");}

//---
if ( chislo < 0 )
{System.Console.WriteLine($"Введенное Вами число {chislo} меньше нуля");}