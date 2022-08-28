/*
Задача 1: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.
*/

//Блок (функция) запроса и ввода данных:
/*
Не люблю int почти всегда работаю со float
довольно таки редко с double
Перехожу на int только когда что-то округляю
*/
float DataVvod(string message)
{
//Console.Write(message);
System.Console.Write(message);
string strValue = Console.ReadLine() ?? ""; 
//int Value = int.Parse (strValue);
float Value = float.Parse (strValue);
return Value;
}

//В чем разница между System.Console.Write и Console.Write - ?
//На первый взгляд оде функции работают одинаково. 
System.Console.WriteLine("Данная программа принимает два числа и выдаёт, какое число большее, а какое меньше.");
//Console.Write("Данная программа принимает два числа и выдаёт, какое число большее, а какое меньше.");
System.Console.WriteLine("Дробные числа вводить с использованием , иначе выдаст ошибку !");

//Блок ввода переменных
float Value1 = DataVvod("Введите число №1: ");
float Value2 = DataVvod("Введите число №2: ");

//Блок логических условий
if ( Value1 > Value2 ) {System.Console.Write($"Число {Value1} больше числа {Value2}");}
if ( Value1 < Value2 ) {System.Console.Write($"Число {Value2} больше числа {Value1}");}
if ( Value1 == Value2 ) {System.Console.Write($"Число {Value2} равно числу {Value1}");}