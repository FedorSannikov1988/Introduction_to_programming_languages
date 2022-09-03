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

int FayndChislo(int chislo, int namber)
{
//---
    int znak = 1;
    if(chislo<0){znak = -1;}
    int byfer1 = chislo * znak;
    int count = 0;
    while ( byfer1 > 0 )
    {
    byfer1 = byfer1/10;
    count++;
    }
//---
    int iskost = -1;
    if ( namber <= count )
    {
    int byfer2 = chislo * znak;
    for (int i=count; i >= namber; i--)
    {iskost = byfer2%10;byfer2 = byfer2/10;}
    }
    if ( namber <= 0 ) {iskost = -1;}
//---
return iskost;
}

System.Console.WriteLine("Данная программа выводит заданную цифру заданного числа или сообщает, что произошла ошибка ввода");
int chislo = ZaPRoS("Пожалуйста введите число: ", 0);
int namber = ZaPRoS("Пожалуйста введите номер искомой цифры в числе: ", 0);

int Otvet = FayndChislo(chislo, namber);

if (Otvet == -1 )
{System.Console.WriteLine($"Номер искомой цифры {namber} в числе меньше чем количество цифр из которого число состоит или Вы ввели 0 чего тоже делать нельзя");}
else 
{System.Console.WriteLine($"Цифра имеющая порядковый номер {namber} в числе {chislo} равна {Otvet}");}