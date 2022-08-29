/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
----
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
----
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

//Блок вывода сообщений пользователю
System.Console.WriteLine("Данная программа на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N.");
System.Console.WriteLine("Не вводите 0 так так как это не имеет смысла.");
System.Console.WriteLine("Не вводите числа меньше 0 они не соовевуют условию задачи.");

//Ввод числа
int ChiSlo = ZaPRoS("Введите число: ", 0);

//через цикл while
/*
int counter = 0;

while ( counter < (2*ChiSlo)+1 )
{
    System.Console.Write($" {(-1*ChiSlo)+counter} ");
    counter++;
}
*/

//через цикл for (более изящно)
if (ChiSlo>0)
{
for (int i = 0; i < (2 * ChiSlo) + 1; i++)
{System.Console.Write($" {(-1 * ChiSlo) + i} ");}
}

if (ChiSlo<0)
{
System.Console.WriteLine("Вы ввели число меньше 0, что не соовевуют условию задачи");
}

if (ChiSlo==0)
{
System.Console.WriteLine("Вы ввели 0, что не имеет смысла так ответом алгоритма при вводе 0 будет 0");
}