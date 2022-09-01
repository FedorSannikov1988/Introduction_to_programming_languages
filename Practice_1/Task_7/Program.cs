/*
Программа для вычисления факториала введенного числа
*/

//Блок ввода данных
int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    int Value = int.Parse(strValue);
    return Value;
}

int Chislo = ZaPRoS("Введите число факториал которого нужно найти ", 0);
//---
if ( Chislo >= 0 )
{
int FactChislo = 1 ;

for (int i = 1; i <= Chislo; i++)
{
    FactChislo = FactChislo*i;
}

System.Console.WriteLine($"Факториал числа {Chislo} равен {FactChislo}");
}
//---
if ( Chislo < 0 )
{
System.Console.WriteLine("Факториал числа меньше 0 не сущесвует !");
}