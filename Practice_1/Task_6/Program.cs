/*
 Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
1 -> 1 
2 -> 0.5
0.25 -> 4
*/

//Блок ввода (немного модернизировал/параметризировал)
float ZaPRoS(string message, int SposViVoD)
{
if ( SposViVoD == 0 ){ System.Console.Write(message); }
if ( SposViVoD == 1 ){ System.Console.WriteLine(message); }
string strValue = Console.ReadLine() ?? ""; 
float Value = float.Parse (strValue);
return Value;
}

System.Console.WriteLine("Данная программа выдает обратное значение введенного числа");
System.Console.WriteLine("0 вводить нельзя");
System.Console.WriteLine("Пример1: 1 имеет обратное значение 1");
System.Console.WriteLine("Пример2: 2 имеет обратное значение 0,5");
System.Console.WriteLine("Пример3: 0,25 имеет обратное значение 4");

float ChiSlO = ZaPRoS("Введите число обратное значение которого нужно получить ", 0);

if ( ChiSlO == 0 )
{
    System.Console.WriteLine($"Вы ввели {ChiSlO} что не соответствует условию задачи"); 
   
}
//---
else
{
   float ObrChiSlO = 1/ChiSlO ;
   System.Console.WriteLine($"Обратное значение {ChiSlO} равно {ObrChiSlO}");
}