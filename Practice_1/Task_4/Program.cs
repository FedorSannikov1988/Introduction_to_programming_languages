/*
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
----
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
----
*/

//Блок ввода (немного модернизировал/параметризировал)
int ZaPRoS(string message, int SposViVoD)
{
if ( SposViVoD == 0 ){ System.Console.Write(message); }
if ( SposViVoD == 1 ){ System.Console.WriteLine(message); }
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

int ChiSlo = ZaPRoS("Номер дня недели: ", 0);