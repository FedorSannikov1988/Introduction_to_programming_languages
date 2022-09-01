/*
Задача 2: Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из этих чисел.
*/

//Процедура ввода данных
int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0)
    {System.Console.Write(message);}
    if (SposViVoD == 1)
    {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    int Value = int.Parse(strValue);
    return Value;
}

//Создали массив для трех чисел
int[] TriChicla = new int[3];

//Запрашиваем три числа
for (int i = 0; i < 3; i++) 
{
    TriChicla[i] = ZaPRoS($"Введите число №{i+1}: ", 0);
}

//Ищем максимум 3-х чисел
//Можно продолжать модернизировать (превратить в процедуру или складывать максимумы в массив) !
int MaХ = TriChicla[0];

for (int i = 1; i < 3; i++) 
{
   if (MaХ <= TriChicla[i]) {MaХ = TriChicla[i];}
}

System.Console.WriteLine($"Максимальное их трех введенных чисел: {MaХ}");