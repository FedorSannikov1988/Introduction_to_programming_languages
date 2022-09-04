/*
Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.
Пример:
14 -> нет
46 -> нет
161 -> да
*/

int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0)
    {
        System.Console.Write(message);
    }
    if (SposViVoD == 1)
    {
        System.Console.WriteLine(message);
    }
    string strValue = Console.ReadLine() ?? "";
    bool isNumber = int.TryParse(strValue, out int Value);
    if (isNumber)
    {
        return Value;
    }
    throw new Exception("Введенные символы невозможно преобразовать в целое число !");
}

int mamber1 = ZaPRoS("Введите число которое необходимо проверить на кратность 7 и 23: ", 0);

if (mamber1 >= 23)
{
    if ((mamber1 % 23) == 0 && (mamber1 % 7) == 0)
    {
        System.Console.WriteLine($"Число {mamber1} кратно 7 и 23");
    }
    //---
    else
    {
        System.Console.WriteLine($"Число {mamber1} одновременно не кратно 7 и 23");
    }
}
//---
if (mamber1 < 23)
{
    System.Console.WriteLine($"Введенное число {mamber1} меньше 23");
}