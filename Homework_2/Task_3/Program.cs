/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. Не использовать строки для расчета.
Пример:
645 -> 5
78 -> третьей цифры нет
326792 -> 6
*/

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

System.Console.WriteLine("Данная программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
int chislo = ZaPRoS("Пожалуйста введите число: ", 0);

//Определяем отрицательное число или нет
if (chislo > 0)
{

//Проверяем разрядность введеного числа
if (chislo > 99)
{

//Считаем сколько разрядов/цифр в числе
int byfer1 = chislo;
int count = 0;
while ( byfer1 > 0 )
{
    byfer1 = byfer1/10;
    count++;
}
System.Console.WriteLine($"Введенное число {chislo} состоит из {count} цифр (разрядов)");

//Находим третье число
int byfer2 = chislo;
int ost = 0;
//for (int i=count; i >= 3; i--)
for (int i=3; i <= count; i++)
{
    ost = byfer2%10;
    byfer2 = byfer2/10;
    //System.Console.WriteLine($"ost = {ost} byfer2 = {byfer2}");
}
System.Console.WriteLine($"Третья цифра {ost} введенного число {chislo}");

}
else {System.Console.WriteLine($"Третьей цифры в введенном числе {chislo} нет !");}

}
else {System.Console.WriteLine($"Введенное число {chislo} меньше 0 или 0");}