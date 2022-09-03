/*
Напишите программу, которая генерирует несколько случайных чисел, 
и в цикле проверяет, кратны ли эти числа предварительно введенному 
числу, при кратности - цикл прерывается.
Пример:
Введенное число 2
13 -> нет 
15 -> нет 
12 -> да
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

//Генерируем массив
//---

int[] MassRanChislo = new int[10];

int length = MassRanChislo.Length;

//Проверял работает ли данная функция с переменными
int VerXRand = 1000;
int NiZRand = -1000;

for (int i = 0; i < length; i++) {MassRanChislo[i] = new Random().Next(NiZRand, VerXRand);}

//Выводим массив
//---
for (int i = 0; i < length; i++) {System.Console.WriteLine($"Случайное число {MassRanChislo[i]} с индексом в массимве {i}");}

//P.S.: Специально сначало создал массив а зетем его вывел хотя все можно было сделать за одно действие

//---
int chislo = ZaPRoS("Введите число на кратность к которому нужно проверить массив случайных сгенерированных чисел: ", 0);

//---
//Цикл проверки
for (int i = 0; i < length; i++)
{
    if( MassRanChislo[i] % chislo == 0 ) {System.Console.WriteLine($"Случайное число {MassRanChislo[i]} с индексом в массимве {i} кратно введенному числу {chislo}"); break;}
    //else{System.Console.WriteLine($"Случайное число {MassRanChislo[i]} с индексом в массимве {i} НЕ кратно введенному числу {chislo}");}
    if( MassRanChislo[i] % chislo != 0 ) {System.Console.WriteLine($"Случайное число {MassRanChislo[i]} с индексом в массимве {i} НЕ кратно введенному числу {chislo}");}
}