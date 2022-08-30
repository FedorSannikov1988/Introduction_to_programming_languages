/*
Напишите программу вычисления модуля числа.
Примпер:
2 -> 2
-3 -> 3
-7 -> 7
На практике определились что это будет программа/функция вычисления куба (1 : 20) !
*/

//Блок ввода
int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    int Value = int.Parse(strValue);
    return Value;
}

int Chislo = ZaPRoS("Введите число модуль которого нужно получить: ", 0);

int ByFer;

//---

if ( Chislo < 0 )
{
    ByFer = -1 * Chislo;
}

//---

else
{
    ByFer = Chislo;
}

//---

System.Console.WriteLine($"Модуль числа {Chislo} равен {ByFer}");