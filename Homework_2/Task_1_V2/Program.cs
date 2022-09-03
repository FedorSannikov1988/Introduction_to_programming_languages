/*
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
Пример:
456 -> 5
782 -> 8
918 -> 1
*/

//Процедура ввода данных
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

//Процедура для поиска числа
int FaynChislo(int chislo, int namber)
{

int flag = -2;

if ( chislo > 99 && chislo < 1000 )
{

int byffer = chislo;

int[] massbyffer = new int[3];

for ( int i = 2; i >= 0; i-- )
{
    massbyffer[i] = byffer%10;
    byffer = byffer/10;
}

flag = massbyffer[(namber-1)];

}

if ( chislo <= 99 ) {flag = -1;}
//if ( chislo >= 1000 ) {flag = -2;}

return (flag);

}

//Устанавливаем правила ввода для пользователя 
System.Console.WriteLine("Данная программа на вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.WriteLine("Нумеразия цифр в числе идет слева направо.");

int chislo = ZaPRoS("Пожалуйста введите трехзначное число: ", 0);

int result = FaynChislo(chislo, 2);

if ( result == -1 ) {System.Console.WriteLine($"Введенное Вами число {chislo} имеет всего два знака или меньше");}
if ( result == -2 ) {System.Console.WriteLine($"Введенное Вами число {chislo} имеет целых четыре знака или больше");}
if ( result > 0 ) {System.Console.WriteLine($"Цифра № 2 введенного Вами числа {chislo} равна {result}.");}