/*
Напишите программу, которая будет принимать 
на вход пять чисел и выводить сумму и среднее 
арифметическое этих чисел.
Пример:
2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 
*/

int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    bool isNumber = int.TryParse(strValue, out int Value);
    if (isNumber) {return Value;}
    throw new Exception ("Введенные символы невозможно преобразовать в целое число типа int !");
}

int[] massbyffer = new int[5];

int length = massbyffer.Length;

for (int i = 0; i < length; i++)
{
    massbyffer[i] = ZaPRoS($"Введите число №{i+1}: ", 0);
}

int SymmMass = 0 ;

for (int i = 0; i < length; i++)
{
    SymmMass = SymmMass + massbyffer[i];
}
//---
System.Console.WriteLine($"Сумма введенных чисел: {SymmMass}");
System.Console.WriteLine($"Среднее арифметическое введенных чисел: {SymmMass/length}");