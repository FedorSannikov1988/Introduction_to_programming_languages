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

//Функция неделька
string WeeK(int NamberDay)
{
  string VaLuE = "Нет такого дня недели !";
  //или хотябы 
  //string VaLuE = ""; - ?
  //Если я работаю со string мне нужно хоть что то присвоить - ?
  //Или это для всех типов переменных
  //Надо проверить !
  if( NamberDay == 1 ){VaLuE = "Понедельник";}
  if( NamberDay == 2 ){VaLuE = "Вторник";}
  if( NamberDay == 3 ){VaLuE = "Среда";}
  if( NamberDay == 4 ){VaLuE = "Четверг";}
  if( NamberDay == 5 ){VaLuE = "Пятница";}
  if( NamberDay == 6 ){VaLuE = "Суббота";}
  if( NamberDay == 7 ){VaLuE = "Воскресенье";}
  return VaLuE;
}

System.Console.WriteLine("Введите число с 1-ого до 7-ми соотвевующее дню недели");

int DaY = ZaPRoS("Номер дня недели: ", 0);

System.Console.WriteLine($"Введенное чиcло соотвует следующему дню недели: {WeeK(DaY)}");