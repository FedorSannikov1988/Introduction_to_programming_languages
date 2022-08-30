/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Пример:
3 -> Среда 
5 -> Пятница
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

/*
Мои эксперименты с синтаксисом массива

float[] mass1 = {1, 2, 3, 4, 5, 6, 7};

System.Console.WriteLine($"{mass1[0]}, {mass1[1]}, {mass1[2]}, {mass1[3]}, {mass1[4]}");

//Как пишется "дробное число" -> 3,14 в массиве ?

float[] mass2 = {1, 2};

System.Console.WriteLine($"{mass2[0]}, {mass2[1]}");
*/

//Подсмотрел на семинаре работу со стринговыми массивами и усовершенсвовал (добавил логичекое условие) !

string[] WeeK = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

System.Console.WriteLine("Введите число с 1-ого до 7-ми соотвевующее дню недели");

int DaY = ZaPRoS("Номер дня недели: ", 0) ;

int ByfeR = DaY - 1 ;

if ( 7 >= DaY && DaY >= 1 )
{
  System.Console.WriteLine($"Введенное чиcло соотвует следующему дню недели: {WeeK[ByfeR]}");
}
if (DaY <= 0 )
{
  System.Console.WriteLine("Вы ввели число меньше 0 или 0");
}
if ( DaY >= 8 )
{
  System.Console.WriteLine("Вы ввели число больше 7");
}