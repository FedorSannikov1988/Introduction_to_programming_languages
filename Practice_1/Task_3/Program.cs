/*
Напишите программу вычисления функции: x = f(a)
На практике определились что это будет программа/функция вычисления куба (1 : 12) !
*/

int ZaPRoS(string message, int SposViVoD)
{
if ( SposViVoD == 0 ){ System.Console.Write(message); }
if ( SposViVoD == 1 ){ System.Console.WriteLine(message); }
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

System.Console.WriteLine("Программа вычисляет куб введеного числа");

int ChiSlo = ZaPRoS("Введите число: ", 0);

System.Console.Write($"Куб {ChiSlo} равен ");
System.Console.Write ($"{ChiSlo*ChiSlo*ChiSlo}");