/*
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
Пример:
456 -> 5
782 -> 8
918 -> 1
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
//Устанавливаем правила ввода для пользователя 
System.Console.WriteLine("Данная программа на вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.WriteLine("Нумеразия цифр в числе идет слева направо.");

int chislo = ZaPRoS("Пожалуйста введите трехзначное число: ", 0);

// Проверяем дейсвительно мы имеем дело с 3-х значным числом
if ( chislo > 99 && chislo < 1000 )
{
//Контейнер для того что бы сохранить орегинальное введеное число
int byffer = chislo;

int[] massbyffer = new int[3];

for (int i = 2; i >= 0; i--)
{
    massbyffer [i] = byffer%10;
    byffer = byffer/10;
}
System.Console.WriteLine($"Вторая цифра {massbyffer [1]} введенного Вами числа {chislo}.");
}

else
{
  System.Console.WriteLine($"Введенное Вами число {chislo} не является трехзначным");
}