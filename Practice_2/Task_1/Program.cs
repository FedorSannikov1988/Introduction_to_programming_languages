/*
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает последнюю цифру этого числа.
*/

//По факту здесь можно ввести любые символы !
System.Console.Write("Введите трехзначное число: ");
string Value = Console.ReadLine() ?? "";
char LastChar = Value [ Value.Length - 1 ];

//---

System.Console.WriteLine( LastChar );

//Сам добавил :
System.Console.WriteLine( "---" );
System.Console.WriteLine( Value[0] );
System.Console.WriteLine( Value[1] );
System.Console.WriteLine( Value[2] );

//Вообще так делать было ненужно !!!

//Пытался сказать непослушали !!!

//Очень плохое решение: нет проверок и прочего !

//Но зато я научилмя работать с массивом string !