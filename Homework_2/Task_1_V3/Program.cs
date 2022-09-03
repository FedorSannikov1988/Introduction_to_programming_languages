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
int FaynChislo(int isxchislo, int namber)
{

int znak = 1;

int flag = -2;

if (isxchislo < 0) {znak = -1;}

int chislo = isxchislo * znak;

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

return (flag);

}

//Устанавливаем правила ввода для пользователя 
System.Console.WriteLine("Данная программа на вход принимает трёхзначное число и на выходе показывает цифру порядковый номер которой будет введен");
System.Console.WriteLine("Нумераwия цифр в числе идет слева направо.");

int chislo = ZaPRoS("Пожалуйста введите трехзначное число: ", 0);
int namberchislo = ZaPRoS("Пожалуйста введите порядковый номер числа от 1-ого до 3-х которое нужно вывести: ", 0);

//Я тут немного схалтурил :-) но ей богу надоего обвязывать алгоритм различными условиями.
//А так как не бейся головой о стену а неправильное число не введешь )))
if (namberchislo>3) {namberchislo = 3;}
if (namberchislo<1) {namberchislo = 1;}

int result = FaynChislo(chislo, namberchislo);

if ( result == -1 ) {System.Console.WriteLine($"Введенное Вами число {chislo} имеет всего два знака или меньше");}
if ( result == -2 ) {System.Console.WriteLine($"Введенное Вами число {chislo} имеет целых четыре знака или больше");}
if ( result > 0 ) {System.Console.WriteLine($"Цифра № {namberchislo} введенного Вами числа {chislo} равна {result}.");}