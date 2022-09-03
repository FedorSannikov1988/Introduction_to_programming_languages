/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот 
день выходным.
Пример:
6 -> да 
7 -> да 
1 -> нет
*/

//Что то похожее мы делали на практике !

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

string[] WeeK = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

System.Console.WriteLine("Данная программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным или будним");

System.Console.WriteLine("Введите число с 1-ого до 7-ми соотвевующее дню недели");

int DaY = ZaPRoS("Номер дня недели: ", 0);

int ByfeR = DaY - 1 ;

if ( 7 >= DaY && DaY >= 1 )
{
if ( 5 >= DaY && DaY >= 1 ) {System.Console.WriteLine($"Введенное чиcло соотвует следующему БУДНЕМУ дню недели: {WeeK[ByfeR]}");}
if ( 7 >= DaY && DaY >= 6 ) {System.Console.WriteLine($"Введенное чиcло соотвует следующему ВЫХОДНОМУ дню недели: {WeeK[ByfeR]}");}
}
//---
if ( DaY <= 0 ) {System.Console.WriteLine("Вы ввели число меньше 0 или 0 такого дня недели нет !");}
//---
if ( DaY >= 8 ) {System.Console.WriteLine("Вы ввели число больше 7 такого дня недели нет !");}