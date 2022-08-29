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

System.Console.WriteLine("Введите число с 1-ого до 7-ми соотвевующее дню недели");

int DaY = ZaPRoS("Номер дня недели: ", 0);

//Логический блок
if (DaY >=1 )
{
  System.Console.WriteLine("Введенное чиcло соотвует следующему дню недели:");
  if( DaY == 1 ){System.Console.WriteLine("Понедельник");}
  if( DaY == 2 ){System.Console.WriteLine("Вторник");}
  if( DaY == 3 ){System.Console.WriteLine("Среда");}
  if( DaY == 4 ){System.Console.WriteLine("Четверг");}
  if( DaY == 5 ){System.Console.WriteLine("Пятница");}
  if( DaY == 6 ){System.Console.WriteLine("Суббота");}
  if( DaY == 7 ){System.Console.WriteLine("Воскресенье");}
}
else
{
  System.Console.WriteLine("Вы ввели число меньше 0 или 0 !");
}