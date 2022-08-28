/* 
Задача 2: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.
*/

//Блок (функция) запроса и ввода данных:
float DataVvod(string message)
{
System.Console.Write(message);
string strValue = Console.ReadLine() ?? ""; 
float Value = float.Parse (strValue);
return Value;
}

System.Console.WriteLine("Данная программа принимает три числа и выдаёт, максимальное из этих чисел.");
System.Console.WriteLine("Пользователь обратите внимание программа работает с float");
System.Console.WriteLine("Дробные числа вводить с использованием , иначе выдаст ошибку!");

//Блок ввода данных (переменных)
float Value1 = DataVvod("Введите число №1: ");
float Value2 = DataVvod("Введите число №2: ");
float Value3 = DataVvod("Введите число №3: ");

/*
Содрал алгоритм с лекции ( так как стало лень :-) ) 
придумывать что - то более изящное (работает ведь)
хотя по хорошему нужно массив данных заводить и использовать цикл
К слову сказать Лектор не использует {} при использовании if
*/

//Блок условий поиска максимального числа
float MaХ = Value1;

if (Value1 > MaХ) {MaХ = Value1;}
if (Value2 > MaХ) {MaХ = Value2;}
if (Value3 > MaХ) {MaХ = Value3;}

System.Console.WriteLine($"Максимальное число {MaХ} из чисел {Value1}, {Value2}, {Value3}");